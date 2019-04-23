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

    public interface IResultLessonService
    {
        ResultLesson Add(ResultLesson postCategory);

        void Update(ResultLesson postCategory);

        ResultLesson Delete(int id);

        IEnumerable<ResultLesson> GetAll();

        ResultLesson GetById(int id);

        void Save();
    }

    public class ResultLessonService : IResultLessonService
    {
        private IResultLessonRepository _ResultLessonRepository;
        private IUnitOfWork _unitOfWork;

        public ResultLessonService(IResultLessonRepository ResultLessonRepository, IUnitOfWork unitOfWork)
        {
            this._ResultLessonRepository = ResultLessonRepository;
            this._unitOfWork = unitOfWork;
        }

        public ResultLesson Add(ResultLesson resultLesson)
        {
            return _ResultLessonRepository.Add(resultLesson);
        }

        public ResultLesson Delete(int id)
        {
            return _ResultLessonRepository.Delete(id);
        }

        public IEnumerable<ResultLesson> GetAll()
        {
            return _ResultLessonRepository.GetAll();
        }



        public ResultLesson GetById(int id)
        {
            return _ResultLessonRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ResultLesson resultLesson)
        {
            _ResultLessonRepository.Update(resultLesson);
        }
    }

}
