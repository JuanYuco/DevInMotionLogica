using ConsoleApp1.BL;

namespace ConsoleApp1.Puntos
{
    public class SocioAntiguedad
    {
        public SocioAntiguedad()
        {
            Iniciar();
        }

        private Socio SetSocio(string orden)
        {
            Console.WriteLine($"Escribe el nombre del socio {orden}");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine($"Escribe la antiguedad del socio {orden}");
            int antiguedad = int.Parse(Console.ReadLine());
            return new Socio(nombre, antiguedad);
        }

        private void Iniciar()
        {
            Socio socioUno = SetSocio("1");
            Socio socioDos = SetSocio("2");
            Socio socioTres = SetSocio("3");

            Club club = new Club(socioUno, socioDos, socioTres);
            club.GetSocioMasAntiguo();
        }
    }
}
