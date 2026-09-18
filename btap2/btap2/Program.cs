using System;
namespace btap2

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            int dem = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (char.IsLetterOrDigit(chuoi[i]))
                {
                    dem++;
                }
            }
            Console.WriteLine("So luong ky tu khong tinh khoang trang va dau cau = " + dem);
            Console.ReadKey();
        }
    }
}