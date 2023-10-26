namespace MVCCountriesLab
{
    public class CountryView
    {
        public Country DisplayCountry { get; private set; }

        // Define a mapping of country colors to console colors
        private static Dictionary<string, ConsoleColor> colorMap = new Dictionary<string, ConsoleColor>
    {
        { "Red", ConsoleColor.Red },
        { "White", ConsoleColor.White },
        { "Blue", ConsoleColor.Blue }
        // Add more colors as needed
    };

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine($"Country: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine("Colors:");

            // Change console colors based on the country's colors
            foreach (var color in DisplayCountry.Colors)
            {
                if (colorMap.ContainsKey(color))
                {
                    Console.ForegroundColor = colorMap[color];
                }
                Console.WriteLine($"- {color}");
            }

            // Reset console colors to their default values
            Console.ResetColor();
        }
    }
}