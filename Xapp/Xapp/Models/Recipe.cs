using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Xapp.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PrepTime { get; set; }
        public int CookingTime { get; set; }
        public ObservableCollection<Directions> Directions { get; set; }
    }
}
