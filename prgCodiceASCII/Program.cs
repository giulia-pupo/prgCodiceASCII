using System;

namespace prgCodiceASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserici un valore numerico o alfanumerico da convertire in ASCII ");
            char carattere = Convert.ToChar(Console.ReadLine());
            int number = carattere;
            //aggiunge 4 al numero decimale corrispondente della lettera inserita
            //number =  number +4;
     
            Console.WriteLine($"Il carattere digitato corrisponde al numero: {number.ToString()}");
            string binario = Convert.ToString(number, 2).PadLeft(8, 'o');

            Console.WriteLine($"Il carattere in codice binaro corrisponde alla sequanza di bit {binario}");
            Console.ReadKey();
        }
    }
}
