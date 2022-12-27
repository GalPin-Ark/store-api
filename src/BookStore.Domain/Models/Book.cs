using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    public class Book : Entity
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public String Description { get; set; }
        public double Value { get; set; }
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }


        /* EF Relation*/
        public Category Category { get; set; }
    }
}
