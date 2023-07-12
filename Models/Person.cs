namespace Newapp.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public void EnterData()
        {
            System.Console.WriteLine("ho va ten = ");
            FullName = Console.ReadLine();
            System.Console.WriteLine("dia chi = ");
            Address = Console.ReadLine();
            
        }
    }
}