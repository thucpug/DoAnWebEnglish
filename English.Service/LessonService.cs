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

    public interface ILessonService
    {
        Lesson Add(Lesson lesson);

        void Update(Lesson lesson);

        Lesson Delete(int id);

        IEnumerable<Lesson> GetAll();

        Lesson GetById(int id);

        void Save();
    }

    public class LessonService : ILessonService
    {
        private ILessonRepository _LessonRepository;
        private IUnitOfWork _unitOfWork;

        public LessonService(ILessonRepository lessonRepository, IUnitOfWork unitOfWork)
        {
            this._LessonRepository = lessonRepository;
            this._unitOfWork = unitOfWork;
        }

        public Lesson Add(Lesson lesson)
        {
            return _LessonRepository.Add(lesson);
        }

        public Lesson Delete(int id)
        {
            return _LessonRepository.Delete(id);
        }

        public IEnumerable<Lesson> GetAll()
        {
            return _LessonRepository.GetAll();
        }
        public Lesson GetById(int id)
        {
            return _LessonRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Lesson lesson)
        {
            _LessonRepository.Update(lesson);
        }
    }

}
