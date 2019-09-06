using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Task_ListOfEmployees.Models;

namespace Task_ListOfEmployees.Controllers
{
    public class HomeController : Controller
    {
        ListEmpContext db = new ListEmpContext();
        public ActionResult Index()
        {         
            IQueryable<Employee> emps = db.Employees.Include(d => d.Departament).Include(l => l.Language);
            return View(emps.ToList());
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
            SelectList depts = new SelectList(db.Departaments, "Id", "Depart_Name");
            ViewBag.Depts = depts;
            SelectList langs = new SelectList(db.Languages, "Id", "LangName");
            ViewBag.Langs = langs;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(Employee addingEmp)
        {
            db.Employees.Add(addingEmp);
            await db.SaveChangesAsync();

            OverallTable table = new OverallTable();
            table.EmployeeId = addingEmp.Id;
            table.DepartamentId = addingEmp.DepartamentId;
            table.LanguageId = addingEmp.LanguageId;
            db.OverallTables.Add(table);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Edit(int? id)
        {
            SelectList depts = new SelectList(db.Departaments, "Id", "Depart_Name");
            ViewBag.Depts = depts;
            SelectList langs = new SelectList(db.Languages, "Id", "LangName");
            ViewBag.Langs = langs;

            if (id == null)
                return HttpNotFound();
            Employee employee = await db.Employees.FindAsync(id);
            if (employee == null)
                return HttpNotFound();
            return View(employee);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            await db.SaveChangesAsync();

            OverallTable table = db.OverallTables.Where(i => i.EmployeeId == employee.Id).SingleOrDefault();
            table.EmployeeId = employee.Id;
            table.DepartamentId = employee.DepartamentId;
            table.LanguageId = employee.LanguageId;
            db.Entry(table).State = EntityState.Modified;
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