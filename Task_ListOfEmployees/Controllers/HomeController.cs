using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_ListOfEmployees.Models;

namespace Task_ListOfEmployees.Controllers
{
    public class HomeController : Controller
    {
        ListEmpContext db = new ListEmpContext();
        public ActionResult Index()
        {
            ViewBag.Employees = db.Employees;
            var employees = db.Employees;
            return View(employees.ToList());
        }

        public ActionResult AddingEmp()
        {
            SelectList depts = new SelectList(db.Departaments, "Id", "Name");
            ViewBag.Depts = depts;
            SelectList langs = new SelectList(db.Languages, "Name", "Name");
            ViewBag.Langs = langs;
            return View();
        }

        [HttpPost]
        public ActionResult AddingEmp(Employee addingEmp)
        {
            SelectList depts = new SelectList(db.Departaments, "Name", "Name");
            ////db.Departaments.OrderBy(i => i.Id).Select(n =>
            ////            new SelectListItem
            ////            {
            ////                Value = n.Id.ToString(),
            ////                Text = n.Name
            ////            }).ToList();
            var selectedItem = depts.Where(x => x.Value == "Middle SE").First();

                     
            addingEmp.departament = selectedItem.Text;
            //Departament departament = new Departament();
            //Employee employee = new Employee
            //{

            //    //Name = addingEmp.Name,
            //    //Surname = addingEmp.Surname,
            //    //Age = addingEmp.Age,
            //    //Gender = addingEmp.Gender,
            //    //Id_department = /*addingEmp.Id_Department*/,

            //    //departament = addingEmp.departamentName.Name,
            //    departament = selectedItem.Text
            //    //Id_Lang = addingEmp.Id_Language
            //};
            db.Employees.Add(addingEmp/*employee*/);
            db.SaveChanges();
         
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}