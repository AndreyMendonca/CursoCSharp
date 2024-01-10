namespace o1 {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\andre\Documents\FACULDADE\in.txt";
            StreamReader sr = null;
            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }catch(IOException e) {
                Console.WriteLine("Error! " + e.Message);
            } finally {
                if (sr != null) sr.Close();
            }
        }
    }
}
