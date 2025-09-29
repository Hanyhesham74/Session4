using Comoany.G01.DAL.Models;
using Company.G01.BLL.Interfaces;
using Company.G01.BLL.Repositories;
using Company.G01.PL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Company.G01.PL.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository) { 
         _departmentRepository = departmentRepository; 
        }
        [HttpGet]
        public IActionResult Index()
        {
            
            var departments = _departmentRepository.GetAll();    
            return View(departments); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateDepartmentDto model)
        {
            if (ModelState.IsValid) {
                var department = new Department()
                {
                    Code =model.Code,
                    Name = model.Name,
                    CreatAt = model.CreatAt
                };
               var count= _departmentRepository.Add(department);
                if (count > 0) { 
                 return RedirectToAction("Index");
                }

            }
            return View(model); 
        }
    }
}
