namespace Newapp.Models
{
    public class YourClass
    {
        public int studentID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public void Input()
        {
            System.Console.Write("StudentID: ");
            studentID = Convert.toInt32(Console.ReadLine());
            System.Console.Write("Ho Ten Sinh Vien: ");
            FullName = Console.ReadLine();
            System.Console.Write("Age: ");
            Age = Convert.toInt16(Console.ReadLine());
        }
        public void Output()
        {
            System.Console.WriteLine("Ma Sinh Vien: {0} - Ho va ten: {1} - Tuoi: {2}", studentID,FullName,Age);
        }
        
    }
    public class Employee
    {
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int Luong { get; set; }
        public void NhapThongTin()
        {
            System.Console.Write("ma nhan vien: ");
            MaNhanVien = Convert.toInt32(Console.ReadLine());
            System.Console.Write("Ho Ten Nhan Vien: ");
            HoTen = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Tuoi = Convert.toInt16(Console.ReadLine());
            System.Console.Write("Luong: ");
            Luong = Convert.toInt32(Console.ReadLine());
        }
        public void XuatThongTin()
        {
            System.Console.WriteLine("ma nhan vien: {0} - ho ten: {1} - tuoi: {2} - luong: {3}",MaNhanVien,HoTen,Tuoi,Luong)
        }
    }
}