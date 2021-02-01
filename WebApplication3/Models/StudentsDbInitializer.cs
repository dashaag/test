using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class StudentsDbInitializer : DropCreateDatabaseAlways<StudentsContext>
    {
        protected override void Seed(StudentsContext context)
        {
            context.Students.Add(new Student { Name = "Oleg", Age = 25, Course = "Programming", Group = "ПД925", Stars = 500 });
            context.Students.Add(new Student { Name = "Oleg", Age = 25, Course = "Programming", Group = "ПД925", Stars = 500 });
            context.Students.Add(new Student { Name = "Oleg", Age = 25, Course = "Programming", Group = "ПД925", Stars = 500 });
            base.Seed(context);
        }
    }
}