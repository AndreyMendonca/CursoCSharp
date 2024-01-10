namespace BlocoUsing {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\andre\Documents\FACULDADE\in.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
