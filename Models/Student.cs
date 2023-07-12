namespace Newapp.Models
{
    public class Student : Person
    {
        public string StudentCode { get; set; }

        public void XuatThongTin()
        {
            System.Console.WriteLine("hoten: {0} - địa chỉ: {1} - studencode: {2}",FullName,Address,StudentCode);
        }

        
        
    }
    }