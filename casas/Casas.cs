using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casas
{
    internal class Casas
    {
        public string Casa {  get; set; }
        public int Numero { get; set; }

        public Casas()
        {
            Casa = " sin nombre";
            Numero = 0;
        }
        
        public Casas(string casas)
        {
            Casa = casas;
            Numero = 0;
        }

        public Casas(string casas, int numero)
        {
            Casa= casas;
            Numero = numero;
        }
        ~Casas()
        {
            Console.WriteLine($"casa con numero\"{Numero}\"a sido destruida");
        }

        public void SHOW()
        {
            Console.WriteLine("NUMERO"+Numero);
            Console.Write("Casa a sido destrida"+Casa+"\n\n");
        }

    }
}
