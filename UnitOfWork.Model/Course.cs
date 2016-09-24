using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.Model
{
    public class Course
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public int Level { get; set; }
        public float FullPrice { get; set; }
        public virtual Author Author { get; set; }
        public int AuthorId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public Cover Cover { get; set; }
    }
}
