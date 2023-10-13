namespace Metodos2
{
    public class Classe01
    {
        public static void MetodoPublico(){
            Console.WriteLine("Método publico - Classe 01");
        }

        internal static void MetodoInternal(){
            Console.WriteLine("Método Internal - Classe 01");
        }

        protected static void MetodoProtegido(){
            Console.WriteLine("Método protegido - Classe 01");
        }

        private static void MetodoPrivado(){
            Console.WriteLine("Método privado - Classe 01");
        }
    }
}