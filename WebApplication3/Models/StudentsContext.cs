﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class StudentsContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}