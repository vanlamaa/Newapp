namespace Newapp.Models
{
    public class SV
    {
        public SV(string ten, int id, int tuoi, int ns)
        {
            FullName = ten;
            studentID = id;
            Age = tuoi;
            Namsinh = ns;
        }
        
        public string FullName { get; set; }
        public int studentID { get; set; }
        public int Age { get; set; }
        public int Namsinh { get; set; }

        public void Hienthi()
        {
            System.Console.WriteLine("Ten sinh vien: {0} - Ma sinh vien: {1} - Tuoi: {2} - Nam sinh: {3}", FullName, studentID, Age, Namsinh);
        }

        
    }
}