using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryProduct> Categories { get; set; }
    }
}
