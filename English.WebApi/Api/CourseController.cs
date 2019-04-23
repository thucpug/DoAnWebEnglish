using English.Model.Model;
using English.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace English.WebApi.Api
{
    
    [RoutePrefix("api/course")]
    public class CourseController : ApiController
    {
        ICourseService _courseService;

        public CourseController(ICourseService courseService) 
        {
            this._courseService = courseService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
                var listCategory = _courseService.GetAll();
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategory);
                return response;

        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, Course courseVm)
        {
                 HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var category = _courseService.Add(courseVm);
                    _courseService.Save();
                    response = request.CreateResponse(HttpStatusCode.Created, category);
                 }
                return response;
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, Course courseVm)
        {
            
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                _courseService.Update(courseVm);
                _courseService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
      
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                _courseService.Delete(id);
                _courseService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
      
        }
    }
}