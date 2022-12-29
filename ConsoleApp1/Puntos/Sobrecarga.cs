namespace ConsoleApp1.Puntos
{
    public class Sobrecarga
    {
        public void Escribir(out int valor)
        {
            Console.WriteLine("Escriba un valor entero");
            valor = int.Parse( Console.ReadLine() );
        }

        public void Escribir(out string valor)
        {
            Console.WriteLine("Escriba una cadena");
            valor = Console.ReadLine();
        }

        public void Escribir(out double valor)
        {
            Console.WriteLine("Escriba un valor con decimales");
            valor = double.Parse( Console.ReadLine() );
        }

        public void Escribir(out char valor)
        {
            Console.WriteLine("Escriba un caracter");
            valor = char.Parse( Console.ReadLine() );
        }

        public void Escribir(out byte valor)
        {
            Console.WriteLine("Escriba un valor entre 0 y 255");
            valor = byte.Parse( Console.ReadLine() );
        }
    }
}
