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
    
    [RoutePrefix("api/Lesson")]
    public class LessonController : ApiController
    {
        ILessonService _lessonService;

        public LessonController(ILessonService lessonService)
        {
            this._lessonService = lessonService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            var listCategory = _lessonService.GetAll();
            HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listCategory);
            return response;

        }

        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, Lesson lessonVm)
        {
            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {
                request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            else
            {
                var temp = _lessonService.Add(lessonVm);
                _lessonService.Save();
                response = request.CreateResponse(HttpStatusCode.Created, temp);
            }
            return response;
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, Lesson lessonVm)
        {

            HttpResponseMessage response = null;
            if (ModelState.IsValid)
            {
                request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            else
            {
                _lessonService.Update(lessonVm);
                _lessonService.Save();

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
                _lessonService.Delete(id);
                _lessonService.Save();

                response = request.CreateResponse(HttpStatusCode.OK);

            }
            return response;

        }
    }
}