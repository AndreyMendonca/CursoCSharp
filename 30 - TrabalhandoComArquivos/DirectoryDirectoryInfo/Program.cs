namespace directory {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\andre\Documents\FACULDADE";

            try {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders) {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                //criar pastas
                Directory.CreateDirectory(path+"\\newFolder");
            }
            catch(IOException e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
