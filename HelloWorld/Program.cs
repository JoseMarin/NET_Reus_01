using System;


namespace HelloWorld
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            Images.FileHanding f1 = new Images.FileHanding();
            f1.Saludar("Jose");
            Console.ReadLine();

            //Tipos de datos integrados
            int x = 123;
            Console.WriteLine(x.GetType());

            int[] num = new int[5];
            num[1] = 48;

            foreach (int numb in num) {

                Console.Write($"{numb} ");
            }

            Console.WriteLine(Math.Sqrt(25));
            

        }
    }
}
