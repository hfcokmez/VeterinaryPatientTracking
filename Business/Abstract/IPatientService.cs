using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPatientService
    {
        IDataResult <Patient> GetById(int Id);
        IDataResult<List<Patient>> GetList();
        IDataResult<List<Patient>> GetList(int pageNumber, int pageSize);
        IDataResult<List<Patient>> GetListSorted();
        IDataResult<List<Patient>> FilterBySpecies(string Species);
        IDataResult<List<Patient>> GetByPetName(string Name);
        IResult Add(Patient patient);
        IResult Delete(Patient patient);
        IResult Update(Patient patient);
    }
}
