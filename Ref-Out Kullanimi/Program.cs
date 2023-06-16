using System;

namespace Ref_Out_Kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2 = 20;
            int sayi3 = 40;
            int sayi4 = 60;

            var result = Add(out sayi1, sayi2);
            var result2 = Add2(ref sayi3, sayi4);
            Console.WriteLine(result);
            Console.WriteLine(result2);

        }

        static int Add(out int sayi1, int sayi2)
        {
            sayi1 = 30;
            return sayi1 + sayi2;
        }
        static int Add2(ref int sayi3, int sayi4)
        {
            sayi3 = 20;
            return sayi3 + sayi4;
        }


    }

    
}
