using System;
using System.Linq;
using System.Collections.Generic;
using yearn.modules.domainobjects;

namespace yearn.modules.rules
{
    public class StudentFacade
    {
        public Student get_student(int id)
        {
            using (var context = new DataContext())
            {
                return context.Student.Where(s => s.Id == id).FirstOrDefault();
            }
        }

        public List<Student> get_students()
        {
            using (var context = new DataContext())
            {
                return context.Student.OrderBy(s => s.StudentNumber).ToList();
            }
        }

        public Student save_student(Student )
    }
}


