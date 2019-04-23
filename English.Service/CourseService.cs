using English.Data.Infrastructure;
using English.Data.Repositories;
using English.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Service
{

    public interface ICourseService
    {
        Course Add(Course course);

        void Update(Course course);

        Course Delete(int id);

        IEnumerable<Course> GetAll();

        Course GetById(int id);

        void Save();
    }

    public class CourseService : ICourseService
    {
        private ICourseRepository _CourseRepository;
        private IUnitOfWork _unitOfWork;

        public CourseService(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
        {
            this._CourseRepository = courseRepository;
            this._unitOfWork = unitOfWork;
        }

        public Course Add(Course course)
        {
            return _CourseRepository.Add(course);
        }

        public Course Delete(int id)
        {
            return _CourseRepository.Delete(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return _CourseRepository.GetAll();
        }
        public Course GetById(int id)
        {
            return _CourseRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Course course)
        {
            _CourseRepository.Update(course);
        }
    }

}
