using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Uygulama.Models
{
    public class StudentRepository
    {
        public static List<StudentModel> StudentList() 
        {
            List<StudentModel> studentList = new List<StudentModel>();
            studentList.Add(new StudentModel { ID = 1, name = "Hasan", surname = "Koç" });
            studentList.Add(new StudentModel { ID = 2, name = "Hüseyin", surname = "Koç" });
            studentList.Add(new StudentModel { ID = 3, name = "İlter", surname = "erdem" });
            studentList.Add(new StudentModel { ID = 4, name = "Sinan", surname = "sarışen" });
            studentList.Add(new StudentModel { ID = 5, name = "Barış", surname = "Müçtebaoğlu" });

            return studentList;
        } 

    }
}