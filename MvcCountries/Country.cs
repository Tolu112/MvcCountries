using System;
using System.Drawing;

namespace MvcCountries
{
    public class Country
    {
        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
        //Properties
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }
        
    }

}

//Make a Country model with the following properties: 
//Public string Name 
//Public string Continent (Or an enum if you feel spicy and we’ve gone over that) 
//Public List<string> Colors

