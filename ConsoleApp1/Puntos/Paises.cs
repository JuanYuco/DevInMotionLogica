namespace ConsoleApp1.Puntos
{
    public class Paises
    {
        string[] paises;

        public Paises()
        {
            paises = new string[5];
        }
        public void SetPaises()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("Escribe el nombre de un país");
                string pais = Console.ReadLine() ?? "";
                GuardarPais(pais);
            }
        }

        private void GuardarPais(string pais)
        {
            for (int y = 0; y < paises.Length; y++)
            {
                if (paises[y] == null)
                {
                    paises[y] = pais;
                    break;
                }
                else if (pais.CompareTo(paises[y]) < 0)
                {
                    string paisCopy = pais;
                    pais = paises[y];
                    paises[y] = paisCopy;
                }
            }
        }
        
        public void MostarPaises()
        {
            Console.WriteLine("\nPaises Ordenados");
            for ( int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }
    }
}
