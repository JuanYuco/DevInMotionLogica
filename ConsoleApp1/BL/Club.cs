namespace ConsoleApp1.BL
{
    public class Club
    {
        private Socio SocioUno;
        private Socio SocioDos;
        private Socio SocioTres;

        public Club(Socio socioUno, Socio socioDos, Socio socioTres)
        {
            SocioUno = socioUno;
            SocioDos = socioDos;
            SocioTres = socioTres;
        }

        public void GetSocioMasAntiguo()
        {
            List<Socio> socioList = new List<Socio>()
            {
                SocioUno, SocioDos, SocioTres
            };

            Socio socioResult = socioList
                                   .OrderByDescending(socio => socio.GetAntiguedad())
                                   .ToList()
                                   .First();
            Console.WriteLine($"Nombre: {socioResult.GetNombre()}, Antiguedad: {socioResult.GetAntiguedad()}");
        }
    }
}
