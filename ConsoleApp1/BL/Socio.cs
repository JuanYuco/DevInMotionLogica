namespace ConsoleApp1.BL
{
    public class Socio
    {
        private string Nombre;
        private int Antiguedad;

        public Socio(string nombre, int antiguedad)
        {
            Nombre = nombre;
            Antiguedad = antiguedad;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public int GetAntiguedad()
        {
            return Antiguedad;
        }
    }
}
