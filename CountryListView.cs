namespace MVCCountriesLab
{
    public class CountryListView
    {
        public List<CountryModel> Countries { get; private set; }

        public CountryListView(List<CountryModel> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            Console.WriteLine("List of Countries:");
            for (int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Countries[i].Name}");
            }
        }
    }
}