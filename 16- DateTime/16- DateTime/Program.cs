using System.Globalization;

namespace Datetime {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            // data normal
            DateTime d2 = new DateTime(2020, 11, 20);
            // data com hora
            DateTime d3 = new DateTime(2020, 11, 20,20,02,31);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            //data de hoje
            DateTime d4 = DateTime.Today;
            //com fuso horario
            DateTime d5 = DateTime.UtcNow;
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            //parse
            DateTime d6 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d6);
            /*
             outros formatos aceitos
                2000-08-13 13:05:58
                10/10/2000 (BR)
             */

            //ParseExact
            DateTime d7 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d8 = DateTime.ParseExact("15/08/2000 13:05:09", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
        }
    }
}