using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            try
            {
                ChiaHaiSo(a, b);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Loi: {ex}");
            }
            finally
            {
                Console.WriteLine("Ket thuc chuong trinh");
            }
            Console.ReadKey();
        }

        static void ChiaHaiSo(int soBiChia, int soChia)
        {
            if (soChia == 0)
            {
                throw new DivideByZeroException("Khong the chia cho 0");
            }
            else {
                int result = soBiChia / soChia;
                Console.WriteLine($"Ket qua cua phep chia: {result}");
            }
        }
    }

}
