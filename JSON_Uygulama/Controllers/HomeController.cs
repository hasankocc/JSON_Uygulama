using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JSON_Uygulama.Models;

namespace JSON_Uygulama.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetStudent(int id)
        {
            StudentModel model = new StudentModel();
            model = StudentRepository.StudentList().FirstOrDefault(x => x.ID == id);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetStudentAll()
        {
            List<StudentModel> model = StudentRepository.StudentList();
            return Json(model, JsonRequestBehavior.AllowGet);

        }
    }
}
