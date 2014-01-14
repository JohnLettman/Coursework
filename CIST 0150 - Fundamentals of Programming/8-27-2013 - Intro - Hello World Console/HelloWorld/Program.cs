using System;
using System.IO.Ports;

namespace UPitt.Bradford.CIST_150.Fall_2013.John_Lettman.Hello_World
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello World in the Console!";

            /*
             * Loop through saying hello world 10,000 times.
             * We use a 16-bit unsigned value as it is the smallest
             * integer container that can contain 10,000.
             */

            for(UInt16 i = 0; i <= 10000; i++)
            {
                Console.WriteLine("Wello World! I've greeted you " + 
                    i.ToString() + " times.");
            }

            /*
             * Next  
             */


            string[] serial_ports = System.IO.Ports.SerialPort.GetPortNames();

            Console.Write("Available ports:");
            foreach (string port in serial_ports)
            {
                Console.Write(" " + port);
            }

            Console.Write('\n');

            while (true) ;
        }
    }
}
