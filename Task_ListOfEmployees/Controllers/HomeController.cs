using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
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

        public ActionResult AutocompleteSearch(string term)
        {
            var models = db.Employees.Where(a => a.Name.Contains(term))
                            .Select(a => new { value = a.Name })
                            .Distinct();

            return Json(models, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Add()
        {
            SelectList depts = new SelectList(db.Departaments, "Depart_Name", "Depart_Name");
            ViewBag.Depts = depts;
            SelectList langs = new SelectList(db.Languages, "LangName", "LangName");
            ViewBag.Langs = langs;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(Employee addingEmp, FormCollection form)
        {
            //SelectList depts = new SelectList(db.Departaments, "Name", "Name");
            addingEmp.departament = form["Depart_Name"].ToString();
            addingEmp.Id_department = db.Departaments.Where(x => x.Depart_Name == addingEmp.departament).SingleOrDefault()?.Id;

            addingEmp.language = form["LangName"].ToString();
            addingEmp.Id_Lang = db.Languages.Where(x => x.LangName == addingEmp.language).SingleOrDefault()?.Id;

            db.Employees.Add(addingEmp);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Edit(int? id)
        {
            SelectList depts = new SelectList(db.Departaments, "Depart_Name", "Depart_Name");
            ViewBag.Depts = depts;
            SelectList langs = new SelectList(db.Languages, "LangName", "LangName");
            ViewBag.Langs = langs;

            if (id == null)
                return HttpNotFound();
            Employee employee = await db.Employees.FindAsync(id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(Employee employee, FormCollection form)
        {
            employee.departament = form["Depart_Name"].ToString();
            employee.Id_department = db.Departaments.Where(x => x.Depart_Name == employee.departament).SingleOrDefault()?.Id;

            employee.language = form["LangName"].ToString();
            employee.Id_Lang = db.Languages.Where(x => x.LangName == employee.language).SingleOrDefault()?.Id;

            db.Entry(employee).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int? id)
        {
            Employee employee = await db.Employees.FindAsync(id);
            if(employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int? id)
        {
            Employee employee = await db.Employees.FindAsync(id);
            if(employee != null)
            {
                db.Employees.Remove(employee);
                await db.SaveChangesAsync();
            }          
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}