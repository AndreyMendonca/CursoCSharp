namespace Nullable {
    class Program {
        static void Main(string[] args) {
            double? x = null;
            double? y = 10.0;

            // traz o valor ou zero
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            //Se tem valor (true or false)
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("Valor é nulo");
            }


            // forma de declarar com uma segunda opção

            double? z = null;
            double? w = z ?? 0.0;

        }
    }
}