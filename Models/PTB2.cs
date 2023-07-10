namespace Newapp.Models
{
    public class PTB2
    {
        public void NhapHeSo()
        {
            Console.WriteLine("Nhap he so a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhap he so b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nhap he so c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Phuong trinh co nghiem kep:");
                Console.WriteLine("x = {0}", x);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem.");
            }
        }
    }
}