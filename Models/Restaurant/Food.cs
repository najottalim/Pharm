using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apteka.Models.Restaurant
{
    public class Food
    {
        public string FoodName { get; set; }
        public string FoodType { get; set; }
        public string CorrectedTerm { get; set; }
        public int Calories { get; set; }
        public bool SideItem { get; set; }
        public bool DressingItem { get; set; }
        public string Protein { get; set; }
        public bool KetchupItem { get; set; }
        public bool BreakfastItem { get; set; }
        public int Carbs { get; set; }
        public int Sodium { get; set; }
    }
}
