namespace Module2Assignment
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Company company = new Company();

      // Startup delegates work to Company which then delegates work to HRManager
      company.HireEmployee("John", "Doe", "444-44-4444");
    }
  }
}