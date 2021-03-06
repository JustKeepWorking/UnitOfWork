﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Model
{
    public class Author
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
