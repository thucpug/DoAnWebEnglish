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

    public interface ITextService
    {
        Text Add(Text text);

        void Update(Text text);

        Text Delete(int id);

        IEnumerable<Text> GetAll();

        Text GetById(int id);

        void Save();
    }

    public class TextService : ITextService
    {
        private ITextRepository _TextRepository;
        private IUnitOfWork _unitOfWork;

        public TextService(ITextRepository textRepository, IUnitOfWork unitOfWork)
        {
            this._TextRepository = textRepository;
            this._unitOfWork = unitOfWork;
        }

        public Text Add(Text text)
        {
            return _TextRepository.Add(text);
        }

        public Text Delete(int id)
        {
            return _TextRepository.Delete(id);
        }

        public IEnumerable<Text> GetAll()
        {
            return _TextRepository.GetAll();
        }
        public Text GetById(int id)
        {
            return _TextRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Text text)
        {
            _TextRepository.Update(text);
        }
    }

}
