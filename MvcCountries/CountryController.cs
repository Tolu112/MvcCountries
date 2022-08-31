using System;
using System.ComponentModel;
using MvcCountries;

namespace MvcCountries
{
    public class CountryController
    {
        //Constructor
        public CountryController()
        {

        }

        //Properties
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("Cyprus", "Asia", new List<string> {"Copper", "Green"}),
            new Country("Maldives", "Asia", new List<string> { "Red", "Green", "White" }),
            new Country("Australia", "Australia", new List<string>{"Blue", "Red", "White"}),
            new Country("New Zealand", "Australia", new List<string>{"Blue", "Red", "White"}),
            new Country("Algeria","Africa", new List<string> { "Green", "Red" }),
            new Country("Nigeria","Africa",new List<string>{"Green","White"}),
            new Country("French Polynesia", "Australia/Oceania", new List<string>{"Red", "White", "Gold", "Blue"}),
            new Country("Austria", "Europe", new List<string> {"Red", "White"}),
            new Country("Greenland","North America", new List<string>{"Red","White"}),
            new Country("Guyana", "South America", new List<string> {"Green", "Gold", "Black", "White", "Red"}),
           
        };

        //Methods
        public void CountryAction(Country c)
        {
            CountryView info = new CountryView(c);
            info.Display();
        }

        public void WelcomeAction()
        {
            CountryListView view = new CountryListView(CountryDb);
            
            Console.Write("Welcome to the Country app. Please select a Country from the following list: ");
            
            //Program loop
            bool runProgram = true;
            while (runProgram)
            {
                int input = 0;
                Console.WriteLine();
                view.Display();
                while (true)
                {
               
                    //Validate user entry
                    while (!int.TryParse(Console.ReadLine(), out input))

                    {
                        Console.WriteLine("Invalid input, please enter the Country index number.");
                    }
                    if (input <= 0 || input > CountryDb.Count)
                    {
                        Console.WriteLine("Invalid selection, please try again.");
                    }
                    else
                    {
                        break;
                    }

                }
                Console.Clear();

                //Display user selection
                CountryAction(CountryDb[input - 1]);

                while (true)
                {
                    Console.Write("\nWould you like to continue? y/n: ");
                    string choice = Console.ReadLine().ToLower().Trim();
                    if (choice == "y")
                    {
                        Console.Clear();
                        runProgram = true;
                        break;
                    }
                    else if (choice == "n")
                    {
                        Console.Clear();
                        runProgram = false;
                        Console.Write("Goodbye.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was an invalid entry. Try again.");
                        Console.Clear();
                    }
                }

            }

        }

    }


}


//gold = DarkYellow

//Lastly make a CountryController class. This class will be the big boss
//    of your app and usually where you spend most of your time coding.
//    This class should have the following properties and methods: 
//List<Country> CountryDb - this stands in for our country database.
//    We’ll learn those later, but know the info from the database gets stored in a list 
//Public void CountryAction(Country c) -This will take in a Country model, passing the
//    model into the CountryView constructor, and call Display Country on your CountryView object. 
//Public void WelcomeAction() -This will take no parameter and pass CountryDb into the CountryListView class.
//Then, it will print “Hello, welcome to the country app. Please select a country from the following list:”
//Then it will call Display() on the CountryListView. 
//Next allow the user to select a country by index. Upon getting the country out of CountryDb,
//pass that country along to the CountryAction() method.After that’s done, ask if the user
//    would like to learn about another country. 