using _07_ExercicioPratico.Entities;

namespace exercicio {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();



            Console.Write("Enter file full paht: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant});
                    }

                    Console.WriteLine("Total user: " + set.Count());
                }
            }catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}