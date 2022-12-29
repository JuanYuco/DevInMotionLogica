namespace ConsoleApp1.Puntos
{
    public class Recursividad
    {
        public void Init(string ruta)
        {
            Console.WriteLine(ruta);
            string[] folders = Directory.GetDirectories(ruta);
            foreach (string folder in folders)
            {
                Init(folder);
            }

            string[] files = Directory.GetFiles(ruta);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
