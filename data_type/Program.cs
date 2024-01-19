using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object s1 = 133;
            string s2 = "abc";
            object s3 = 'A';
            dynamic s4 = 10.31321;
            Console.WriteLine(s1+" "+s2+" "+s3+" "+s4);

            int? a = null;
            int? b = 20;
            int c = a ?? b ?? 0;
            Console.WriteLine(c);

            var x = 1e6 + 213.313;
            Console.WriteLine(x.GetType());

            /*
            int m = 24;
            int* n = &m; //con trỏ n lưu địa chỉ của m
            Console.WriteLine("Gia tri bien: ", m);
            Console.WriteLine("Dia chi bien: ", (ulong)n);
            *n = 30; //cập nhật giá trị m
            */
            // muốn sử dụng con trỏ phải sử dụng tùy chọn \unsafe khi biên dịch chương trình

            Console.ReadKey();
        }
    }
}
