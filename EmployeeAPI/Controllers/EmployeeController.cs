using EmployeeDAL.Models;
using EmployeeDAL.Services;
using EmployeeDAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(EmployeeRepository _repo) : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Employee emp = _repo.GetById(id);
            return emp == null ? NotFound() : Ok(emp);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> employees = _repo.GetAll();
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Create(EmployeeAddDTO emp)
        {
            _repo.Create(emp);
            return Ok("Employee added");
        }

        [HttpPut]
        public IActionResult Update(Employee emp)
        {
            _repo.Update(emp);
            return Ok("Employee updated");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repo.SoftDelete(id);
            return Ok("Employee soft deleted");
        }
    }
}
