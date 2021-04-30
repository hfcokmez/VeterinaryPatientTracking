using Business.Abstract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PatientService : IPatientService
    {
        private IPatientDal _patientDal;
        public PatientService(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }
        public IResult Add(Patient patient)
        {
            _patientDal.Add(patient);
            return new SuccessResult("Hasta Kayıt İşlemi Yapıldı");
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult("Hasta Kaydı Silindi");
        }

        public IDataResult<Patient> GetById(int Id)
        {
            return new SuccessDataResult<Patient>(_patientDal.Get(filter: p=> p.Id == Id));
        }
        public IDataResult<List<Patient>> GetList()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetList().ToList());     
        }

        public IDataResult<List<Patient>> FilterBySpecies(string Species)
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetList(filter: p => p.Species == Species).ToList());
        }

        public IDataResult<List<Patient>> GetByPetName(string Name)
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetList(filter: p => p.Name == Name).ToList());
        }

        public IDataResult<List<Patient>> GetListSorted()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetListSorted(filter: p => p.Name).ToList());
        }

        public IResult Update(Patient patient)
        {
            _patientDal.Update(patient);
            return new SuccessResult("Hasta Kaydı Başarıyla Güncellendi");
        }

        public IDataResult<List<Patient>> GetList(int pageNumber, int pageSize)
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetList(pageNumber, pageSize).ToList());
        }
    }
}
