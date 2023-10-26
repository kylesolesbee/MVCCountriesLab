namespace MVCCountriesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountryController controller = new CountryController();
            controller.WelcomeAction();
        }
    }
}