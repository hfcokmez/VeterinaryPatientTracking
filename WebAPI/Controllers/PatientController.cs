using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet(template:"GetAll")]
        public IActionResult GetList()
        {
            var result = _patientService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet(template: "GetByPage")]
        public IActionResult GetByPage(int pageNumber, int pageSize)
        {
            var result = _patientService.GetList(pageNumber,pageSize);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet(template: "GetBySorted")]
        public IActionResult GetBySorted()
        {
            var result = _patientService.GetListSorted();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet(template:"GetById")]
        public IActionResult GetById(int Id)
        {
            var result = _patientService.GetById(Id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet(template: "FilterBySpecies")]
        public IActionResult FilterBySpecies(string Species)
        {
            var result = _patientService.FilterBySpecies(Species);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet(template: "SearchByPetName")]
        public IActionResult GetByPet(string Name)
        {
            var result = _patientService.GetByPetName(Name);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost(template:"Add")]
        public IActionResult Add(Patient patient)
        {
            var result = _patientService.Add(patient);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost(template: "Delete")]
        public IActionResult Delete(Patient patient)
        {
            var result = _patientService.Delete(patient);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost(template: "Update")]
        public IActionResult Update(Patient patient)
        {
            var result = _patientService.Update(patient);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
