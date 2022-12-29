using System.Text.RegularExpressions;

namespace ConsoleApp1.Puntos
{
    public class Diccionario
    {
        Dictionary<string, Dictionary<string, string>> tablaPalabras = new Dictionary<string, Dictionary<string,string>>();

        public Diccionario()
        {
            IniciarPalabras();
            Init();
        }

        private void IniciarPalabras()
        {
            tablaPalabras.Add("Hola", GetDiccionarioIdiomas("Hello", "Olá", "Salut"));
            tablaPalabras.Add("Mundo", GetDiccionarioIdiomas("World", "mundo", "monde"));
            tablaPalabras.Add("Envío", GetDiccionarioIdiomas("Shipping", "expedição", "transport maritime"));
            tablaPalabras.Add("Mercancía", GetDiccionarioIdiomas("Commodity", "mercadoria", "marchandise"));
            tablaPalabras.Add("Lujo", GetDiccionarioIdiomas("Luxury", "luxo", "luxe"));
        }

        private Dictionary<string,string> GetDiccionarioIdiomas(string ingles, string portugues, string frances)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ingles", ingles);
            dic.Add("Portugues", portugues);
            dic.Add("Francés", frances);

            return dic;
        }

        private void Init()
        {
            Console.WriteLine("Escriba la palabra a traducir");
            string palabra = LimpiarTexto(Console.ReadLine());
            Console.WriteLine("Escriba el idioma al que la desea traducir");
            string idioma = LimpiarTexto( Console.ReadLine() );
            foreach ( KeyValuePair<string, Dictionary<string, string>> row in tablaPalabras)
            {
                string key = LimpiarTexto(row.Key);
                if ( palabra != key)
                {
                    continue;
                }

                foreach( KeyValuePair<string, string> traduccion in row.Value)
                {
                    string idiomaKey = LimpiarTexto(traduccion.Key);
                    if ( idioma != idiomaKey)
                    {
                        continue;
                    }

                    Console.WriteLine($"La traducción de {palabra} al idioma {idioma} es { traduccion.Value }");
                    return;
                }
            }
        }

        private string LimpiarTexto(string texto)
        {
            return Regex.Replace(texto.Normalize(System.Text.NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "").ToUpper();
        }
    }
}
