using System;

namespace MyDictinoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictinory<string, string> enTr = new MyDictinory<string, string>();
            enTr.Add("pencil", "Kalem");
            enTr.Add("Book", "Kitap");
            enTr.Add("Plate", "Tabak");
            enTr.Add("Table", "Masa");
            enTr.Add("School", "Okul");
            enTr.Add("Car", "Araba");

            enTr.Write();
        }
    }
}
