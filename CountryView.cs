namespace MVCCountriesLab
{
    public class CountryView
    {
        public CountryModel DisplayCountry { get; private set; }

        public static Dictionary<string, ConsoleColor> colorMap = new Dictionary<string, ConsoleColor>
        {
            { "Red", ConsoleColor.Red },
            { "White", ConsoleColor.White },
            { "Blue", ConsoleColor.Blue },
            { "Black", ConsoleColor.DarkGray },
            { "Yellow", ConsoleColor.Yellow },
            { "Cyan", ConsoleColor.Cyan },
            { "Green", ConsoleColor.Green }
        };


        public CountryView(CountryModel country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine($"Country: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.WriteLine("Colors:");

            foreach (var color in DisplayCountry.Colors)
            {
                if (colorMap.ContainsKey(color))
                {
                    Console.ForegroundColor = colorMap[color];
                }
                Console.WriteLine($"- {color}");
            }

            Console.ResetColor();
        }
    }
}