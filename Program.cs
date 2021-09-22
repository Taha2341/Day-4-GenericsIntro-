using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Mylıst<string> isimler = new Mylıst<string>();
            isimler.Add("engin");
            Console.WriteLine(isimler.length);
            isimler.Add("kerem");
            Console.WriteLine(isimler.length);



        }
    }
}
