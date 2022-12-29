using System.Text.RegularExpressions;

namespace ConsoleApp1.Puntos
{
    public class NumerosAleatoreos
    {
        int[] numeros;
        public NumerosAleatoreos()
        {
            numeros = new int[50000];
            Init();
        }

        private void Init()
        {
            GenerarNumeros();
            PintarNumeros();
        }

        private void GenerarNumeros()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = new Random().Next(1000, 9999);
            }
        }

        private void PintarNumeros()
        {
            Regex regex = new Regex("([1-9])\\1");
            string num;
            for (int i = 0; i < numeros.Length; i++)
            {
                num = numeros[i].ToString();
                if (!regex.IsMatch(num))
                {
                    continue;
                }

                Console.WriteLine(num);
            }
        }
    }
}
