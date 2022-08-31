using System;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Metadata;
using System.Xml.Linq;
namespace MvcCountries
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        //Properties
        public List<Country> Countries { get; set; }

        //Method
        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Countries[i].Name}");
            }
        }
    }
}

//Next Create a CountryListView class.
//    This view will take a list of countries in its constructor.
//    It should have the following property and method: 
//Public List<Country> Countries - store the parameter from the constructor here.
//Public void Display() - Print the name of each country
//in the list along with the index for each country