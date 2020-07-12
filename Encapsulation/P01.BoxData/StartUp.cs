using System;

namespace P01.BoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(lenght, width, height);
                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

           
           

        }
    }
}
