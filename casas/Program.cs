namespace casas
{
    internal class program
    {
        public static void Main(string[] args)
        {
            Casas lugar = new Casas();
            Casas lugar1 = new Casas(" de asturias");
            Casas lugar2 = new Casas(" de asturias",141);
            Console.WriteLine(lugar.Casa + "-" + lugar.Numero);
            Console.WriteLine(lugar1.Casa + "-" + lugar1.Numero);
            Console.WriteLine(lugar2.Casa + "-" + lugar2.Numero);
            lugar.SHOW();
            lugar1.SHOW();
            lugar2.SHOW();
        }

    }
}