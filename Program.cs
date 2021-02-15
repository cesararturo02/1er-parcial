using System;

namespace cajero_automatico
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto, mil, quinientos, docientos, cien;
            int S1 = 0;

            Console.WriteLine("ELIGA UN BANCO PARA LA TRANSACCION... ");
            Console.WriteLine("1. BANCO FDP INVERSMENTS (monto max. 20,000)");
            Console.WriteLine("2. OTRO (monto max. 10,000)");

            S1 = Convert.ToInt16(Console.ReadLine());

            switch (S1)
            {
                case 1:
                    Console.WriteLine("HA ELEGIDO EL BANCO FDP INVERSMENTS, POR FAVOR INGRESE EL MONTO ");
                    monto = int.Parse(Console.ReadLine());

                    if (monto > 20000)
                    {
                        Console.WriteLine("HA EXCEDIDO EL MONTO PERMITIDO...");
                        Console.ReadKey();
                    }
                    else if (monto % 5 == 0)
                    {
                        mil = monto / 1000;
                        monto = monto % 1000;
                        quinientos = monto / 500;
                        monto = monto % 500;
                        docientos = monto / 200;
                        monto = monto % 200;
                        cien = monto / 100;
                        monto = monto % 100;

                        Console.WriteLine("Su monto ingresado en billetes de 1000 es " + mil);
                        Console.WriteLine("Su monto ingresado en billetes de 500 es " + quinientos);
                        Console.WriteLine("Su monto ingresado en billetes de 200 es " + docientos);
                        Console.WriteLine("Su monto ingresado en billetes de 100 es " + cien);
                    }
                    else
                    {
                        Console.WriteLine("MONTO NO VALIDO...");
                    }
                    break;

                case 2:
                    Console.WriteLine("HA ELEGIDO OTRO BANCO, POR FAVOR INGRESE EL MONTO ");
                    monto = int.Parse(Console.ReadLine());

                    if (monto > 10000)
                    {
                        Console.WriteLine("HA EXCEDIDO EL MONTO PERMITIDO...");
                        Console.ReadKey();
                    }
                    else if (monto % 5 == 0)
                    {
                        mil = monto / 1000;
                        monto = monto % 1000;
                        quinientos = monto / 500;
                        monto = monto % 500;
                        docientos = monto / 200;
                        monto = monto % 200;
                        cien = monto / 100;
                        monto = monto % 100;

                        Console.WriteLine("Su monto ingresado en billetes de 1000 es " + mil);
                        Console.WriteLine("Su monto ingresado en billetes de 500 es " + quinientos);
                        Console.WriteLine("Su monto ingresado en billetes de 200 es " + docientos);
                        Console.WriteLine("Su monto ingresado en billetes de 100 es " + cien);
                    }
                    else
                    {
                        Console.WriteLine("MONTO NO VALIDO...");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
