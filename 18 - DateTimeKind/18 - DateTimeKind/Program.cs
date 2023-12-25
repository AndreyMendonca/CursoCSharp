namespace datetimekind{
    class Program {
        static void Main(string[] args) {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("D1 = " + d1);
            Console.WriteLine("D1 = " + d2);
            Console.WriteLine("D1 = " + d3);
            Console.WriteLine("D1 to UTC = " + d1.ToUniversalTime());
            Console.WriteLine();


        }
    }
}