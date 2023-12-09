using System.Globalization;

namespace Vetores {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double[] height = new double[n];

            for(int i = 0; i < n; i++) {
                height[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for(int i = 0; i < n; i++) {
                sum += height[i];
            }

            double avg = sum / n;

            Console.WriteLine("MEDIA DAS ALTURAS: " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
