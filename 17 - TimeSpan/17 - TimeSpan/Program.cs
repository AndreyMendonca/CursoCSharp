
namespace timeSpan {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = TimeSpan.MaxValue;
            TimeSpan t3 = TimeSpan.MinValue;
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t4);
            Console.WriteLine(t4.Days);
            // varias variações
            /* 
                .Hours
                .Minutes
                .Milliseconds
                .Seconds
                  .....
             */

            //OPERAÇÕES
            TimeSpan t5= new TimeSpan(1,30,10);
            TimeSpan t6 = new TimeSpan(0,10,5);

            TimeSpan sum = t5.Add(t6);
            Console.WriteLine(sum);
            /* 
            .Subtracat
            .Multiply ( passando quanto quer multilipcar ex(2.2) )
            .Divide mesma coisa que multiply

             */
        }
    }
}