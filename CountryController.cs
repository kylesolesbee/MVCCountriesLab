using System.Diagnostics.Metrics;

namespace MVCCountriesLab
{
    public class CountryController
    {
        public List<CountryModel> CountryDB = new List<CountryModel>
    {
        new CountryModel { Name = "USA", Continent = "North America", Colors = new List<string> { "Red", "White", "Blue" } },
        new CountryModel { Name = "France", Continent = "Europe", Colors = new List<string> { "Blue", "White", "Red" } },
        new CountryModel { Name = "Japan", Continent = "Asia", Colors = new List<string> { "Red", "White" } },
        new CountryModel { Name = "Germany", Continent = "Europe", Colors = new List<string> { "Black", "Red", "Yellow" } },
        new CountryModel { Name = "Austria", Continent = "Europe", Colors = new List<string> { "Red", "White" } },
        new CountryModel { Name = "Romania", Continent = "Europe", Colors = new List<string> { "Blue", "Yellow", "Red" } },
        new CountryModel { Name = "Poland", Continent = "Europe", Colors = new List<string> { "White", "Red" } },
        new CountryModel { Name = "Italy", Continent = "Europe", Colors = new List<string> { "Green", "White", "Red" } },
        new CountryModel { Name = "Botswana", Continent = "Africa", Colors = new List<string> { "Cyan", "White", "Black" } },
        new CountryModel { Name = "Brazil", Continent = "Africa", Colors = new List<string> { "Yellow", "Green", "Blue", "White" } },
    };

        public void CountryAction(CountryModel c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            CountryListView countryListView = new CountryListView(CountryDB);
            countryListView.Display();

            int selectedIndex;
            while (true)
            {
                Console.Write("Enter the index of the country you want to learn about (or 0 to exit): ");
                if (int.TryParse(Console.ReadLine(), out selectedIndex))
                {
                    if (selectedIndex == 0)
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    if (selectedIndex > 0 && selectedIndex <= CountryDB.Count)
                    {
                        CountryModel selectedCountry = CountryDB[selectedIndex - 1];
                        CountryAction(selectedCountry);

                        Console.Write("Would you like to learn about another country? (y/n): ");
                        if (Console.ReadLine().ToLower() != "y")
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please select a valid index or 0 to exit.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid index or 0 to exit.");
                }
            }
        }
    }
}