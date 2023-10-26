namespace MVCCountriesLab
{
    public class CountryController
    {
        private List<Country> CountryDB = new List<Country>
    {
        new Country { Name = "USA", Continent = "North America", Colors = new List<string> { "Red", "White", "Blue" } },
        new Country { Name = "France", Continent = "Europe", Colors = new List<string> { "Blue", "White", "Red" } },
        new Country { Name = "Japan", Continent = "Asia", Colors = new List<string> { "Red", "White" } },
    };

        public void CountryAction(Country c)
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
                        Country selectedCountry = CountryDB[selectedIndex - 1];
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