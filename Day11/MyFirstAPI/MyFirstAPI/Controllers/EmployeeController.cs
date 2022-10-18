using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Models;
using MyFirstAPI.Services;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]//Attribute based routing
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepo<int, Employee> _repo;

        public EmployeeController(IRepo<int, Employee> repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public ActionResult<Employee> Something(Employee employee)
        {
            var emp = _repo.Add(employee);
            return Created("", emp);
        }
        [Authorize]
        [HttpGet]
        public ActionResult<ICollection<Employee>> GET()
        {
            return Ok(_repo.GetAll());
        }
        [Route("GetEmployeesByDepartment")]
        [HttpGet]
        public ActionResult<ICollection<Employee>> GetEmployeeByDepartment(int dep_id)
        {
            var employees = _repo.GetAll();
            var myEmployess = employees.Where(e => e.DepartmentId == dep_id).ToList();
            if (myEmployess.Count == 0)
                return NotFound("No employees in this department");
            return Ok(myEmployess);
        }
        [HttpPut]
        public ActionResult<Employee> Update(Employee employee)
        {
            var emp = _repo.Update(employee);
            if (emp == null)
                return BadRequest("No such employee");
            return Ok(emp);
        }
       
        [HttpDelete]
        public ActionResult<ICollection<Employee>> Delete(int id)
        {
            var emp = _repo.Delete(id);
            if (emp == null)
                return BadRequest("No such employee");
            return Ok(emp);
        }
    }
}
