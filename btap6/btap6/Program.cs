using System;
namespace btap6

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            Console.Write("Nhap ky tu can dem: ");
            char kyTu = char.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == kyTu)
                {
                    dem++;
                }
            }
            Console.WriteLine("Ky tu '" + kyTu + "' xuat hien " + dem + " lan.");
            Console.ReadKey();
        }
    }
}