namespace ConsoleApp1.Puntos
{
    public class Pila
    {
        List<object> Lista;

        public Pila()
        {
            Lista = new List<object>();
        }

        public void Insertar(object valor)
        {
            Lista.Insert(0, valor);
        }

        public object? Extraer()
        {
            object valor = Lista.FirstOrDefault();
            if (valor != null)
            {
                Lista.RemoveAt(0);
            }
          
            return valor;
        }

        public void Pintar()
        {
            foreach (object valor in Lista)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
