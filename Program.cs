using Newapp.Models;
using System;

public class Program
{
    private static List<Student> studentList = new List<Student>();

    public static void Main(string[] args)
    {
        Console.WriteLine("Chương trình quản lý sinh viên");
        Console.WriteLine("============================");
        
        while (true)
        {
            Console.WriteLine("1. Nhập danh sách sinh viên");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Sửa thông tin sinh viên");
            Console.WriteLine("4. Xóa sinh viên");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    NhapDanhSachSinhVien();
                    break;
                case 2:
                    HienThiDanhSachSinhVien();
                    break;
                case 3:
                    SuaThongTinSinhVien();
                    break;
                case 4:
                    XoaSinhVien();
                    break;
                case 0:
                    Console.WriteLine("Kết thúc chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    public static void NhapDanhSachSinhVien()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Student std = new Student();
            std.EnterData();
            studentList.Add(std);
        }

        Console.WriteLine("Đã nhập thành công danh sách sinh viên.");
    }

    public static void HienThiDanhSachSinhVien()
    {
        if (studentList.Count == 0)
        {
            Console.WriteLine("Danh sách sinh viên trống.");
        }
        else
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (Student std in studentList)
            {
                std.XuatThongTin();
            }
        }
    }

    public static void SuaThongTinSinhVien()
    {
        Console.Write("Nhập mã sinh viên cần sửa: ");
        string maSV = Console.ReadLine();

        bool found = false;
        foreach (Student std in studentList)
        {
            if (std.MaSV == maSV)
            {
                Console.WriteLine("Nhập thông tin mới cho sinh viên:");
                std.EnterData();
                Console.WriteLine("Sửa thông tin sinh viên thành công.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Không tìm thấy sinh viên với mã sinh viên đã nhập.");
        }
    }

    public static void XoaSinhVien()
    {
        Console.Write("Nhập mã sinh viên cần xóa: ");
        string maSV = Console.ReadLine();

        bool removed = false;
        for (int i = 0; i < studentList.Count; i++)
        {
            if (studentList[i].MaSV == maSV)
            {
                studentList.RemoveAt(i);
                Console.WriteLine("Xóa sinh viên thành công.");
                removed = true;
                break;
            }
        }

        if (!removed)
        {
            Console.WriteLine("Không tìm thấy sinh viên với mã sinh viên đã nhập.");
        }
    }
}
