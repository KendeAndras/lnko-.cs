namespace Eiklidesz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bemenet
            int a;
            int b;
            //Kimenet
            int lnko;
            //Hibakezeleshez
            bool error;
            string inputText;

            //Beolv
            Console.WriteLine("legnagyobnb kozos oszto");

            do
            {
                Console.WriteLine("add meg az elsot(szam, nem kisebb mint 0)");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out a) || a <= 0;
                if (error) {
                    Console.WriteLine("ez egesz, 0 nal nagyobb szerinted? na ujra");
                }

            } while (error);

            Console.WriteLine();

            do
            {
                Console.WriteLine("add meg az masodikat(szam, pozitiv)");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out b) || b < 0 ;
                if (error)
                {
                    Console.WriteLine("hat ez se lett pozitiv szam. ujra");
                }

            } while (error);


            //feldolgozas
            //a megoldashoz szukseges valtozok

            int cs;
            int r;

            if(a < b && a != 0)
            {//csere
                cs = a;
                a = b;
                b = cs;
            }
            r = a % b; //maradekos osztas a mod b

            while (r > 0)
            {
                a = b;
                b = r;
                r = a % b;
            }

            lnko = b;
            Console.WriteLine();
            Console.WriteLine("ezeknek a legnagyobb kozos osztoja: {0}", lnko);
        }

        
    }
}