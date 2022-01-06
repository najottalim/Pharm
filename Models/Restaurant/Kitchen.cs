using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.Models.Restaurant
{
    public class Kitchen
    {
        public string Restaurant { get; set; }
        public IList<Food> FoodItems { get; set; }
    }
}
