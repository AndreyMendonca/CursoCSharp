namespace stream {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"C:\Users\andre\Documents\FACULDADE\in.txt";
            string targetPath = @"C:\Users\andre\Documents\FACULDADE\in2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach(string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("Erro " + e.Message);
            }
        }
    }
}
