using System;
using MvcCountries;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace MvcCountries
{
    public class CountryView
    {
        //Constructor
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }
        //Properties
        public Country DisplayCountry { get; set; }

        //Method
        public void Display()
        {
            Console.WriteLine($"Country: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nCountry Colors:");

            //Match console colors to country colors
            foreach (string color in DisplayCountry.Colors)
            {
                if(color == "Copper" || color == "Gold")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                else
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                }

                if (color == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                Console.WriteLine($"- {color}");
                Console.ResetColor();
            }
        }
    }
}

//Next Create a CountryView Class. In the constructor require a Country
//    to be taken in and set to DisplayCountry. Create the following property and method: 
//Public Country DisplayCountry
//Public void Display() -This method will print out the Name, Continent, and
//    Colors of the Country DisplayCountry property

//Extended Exercise: 
//Use Console.Color to change the console’s colors to the country’s
//    colors upon select that country. For Example, for USA, Change the console
//    colors to Red, White, and Blue. Note that Countries have either 2 OR 3 colors,
//    you will have to account for this. 
