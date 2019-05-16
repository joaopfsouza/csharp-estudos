using System;

namespace InterfacesCSharp.Device
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing " + document);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
