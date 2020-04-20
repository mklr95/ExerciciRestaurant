using System;
using System.Collections;

namespace Exercici_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitllet5 = 5;
            int bitllet10 = 10;
            int bitllet20 = 20;
            int bitllet50 = 50;
            int bitllet100 = 100;
            int bitllet200 = 200;
            int bitllet500 = 500;
            int moneda2 = 2;
            int moneda1 = 1;
            int[] list = new int[] { moneda1, moneda2, bitllet5, bitllet10, bitllet20, bitllet50, bitllet100, bitllet200, bitllet500 };
            int preuTotal=0;
            String keepEating="S";
            String[] menu = new string[5];
            int[] preu=new int[5];


            for (int i = 0; i < 5; i++)
            {
                menu[i]= i.ToString() + ": Plato Num " +i.ToString();
                
                preu[i] = RandomNumber(0, 1000);
                Console.WriteLine(menu[i] + " PRECIO: "+ preu[i].ToString());
            }

            var factura = new ArrayList();
            while (keepEating == "S"|| keepEating == "s")
            {
                Console.WriteLine("QUE PLATO QUIERES? Pon el numero");
                var plato = int.Parse(Console.ReadLine()); ;
                factura.Add(plato);
                Console.WriteLine("QUIERES SEGUIR PIDIENDO? S/N");
                keepEating = Console.ReadLine();                
            }
            
            foreach(int item in factura)
            {
                try
                {
                    Console.WriteLine("{0}", menu[item]);
                    preuTotal = preuTotal + preu[item];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("ERROR REGISTRANDO ITEM, PLATO NO EXISTE");
                }                
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("PreuTotal = {0}", preuTotal);


            Console.WriteLine(Environment.NewLine);
            int billeteCount = 0;
            for(int i = 0; i < preuTotal; i+=bitllet500)
            {
                billeteCount++;
            }
            if ((billeteCount * bitllet500) == preuTotal)
            {
                Console.WriteLine(billeteCount + " BILLETES DE 500");
            }
            else
            {
                billeteCount--;
                Console.WriteLine(billeteCount + " BILLETES DE 500");
                int preuRestant1 = preuTotal - (bitllet500 * billeteCount);
                billeteCount = 0;
                for (int i = 0; i < preuRestant1; i += bitllet200)
                {
                    billeteCount++;
                }
                if ((billeteCount * bitllet200) == preuRestant1)
                {
                    Console.WriteLine(billeteCount + " BILLETES DE 200");
                }
                else
                {
                    billeteCount--;
                    Console.WriteLine(billeteCount + " BILLETES DE 200");
                    int preuRestant2 = preuRestant1 - (bitllet200 * billeteCount);
                    billeteCount = 0;
                    for (int i = 0; i < preuRestant2; i += bitllet100)
                    {
                        billeteCount++;
                    }
                    if ((billeteCount * bitllet100) == preuRestant2)
                    {
                        Console.WriteLine(billeteCount + " BILLETES DE 100");
                    }
                    else
                    {
                        billeteCount--;
                        Console.WriteLine(billeteCount + " BILLETES DE 100");
                        int preuRestant3 = preuRestant2 - (bitllet100 * billeteCount);
                        billeteCount = 0;
                        for (int i = 0; i < preuRestant3; i += bitllet50)
                        {
                            billeteCount++;
                        }
                        if ((billeteCount * bitllet50) == preuRestant3)
                        {
                            Console.WriteLine(billeteCount + " BILLETES DE 50");
                        }
                        else
                        {
                            billeteCount--;
                            Console.WriteLine(billeteCount + " BILLETES DE 50");
                            int preuRestant4 = preuRestant3 - (bitllet50 * billeteCount);
                            billeteCount = 0;
                            for (int i = 0; i < preuRestant4; i += bitllet20)
                            {
                                billeteCount++;
                            }
                            if ((billeteCount * bitllet20) == preuRestant4)
                            {
                                Console.WriteLine(billeteCount + " BILLETES DE 20");
                            }
                            else
                            {
                                billeteCount--;
                                Console.WriteLine(billeteCount + " BILLETES DE 20");
                                int preuRestant5 = preuRestant4 - (bitllet20 * billeteCount);
                                billeteCount = 0;
                                for (int i = 0; i < preuRestant5; i += bitllet10)
                                {
                                    billeteCount++;
                                }
                                if ((billeteCount * bitllet10) == preuRestant5)
                                {
                                    Console.WriteLine(billeteCount + " BILLETES DE 20");
                                }
                                else
                                {
                                    billeteCount--;
                                    Console.WriteLine(billeteCount + " BILLETES DE 10");
                                    int preuRestant6 = preuRestant5 - (bitllet10 * billeteCount);
                                    billeteCount = 0;
                                    for (int i = 0; i < preuRestant6; i += bitllet5)
                                    {
                                        billeteCount++;
                                    }
                                    if ((billeteCount * bitllet5) == preuRestant6)
                                    {
                                        Console.WriteLine(billeteCount + " BILLETES DE 5");
                                    }
                                    else
                                    {
                                        billeteCount--;
                                        Console.WriteLine(billeteCount + " BILLETES DE 5");
                                        int preuRestant7 = preuRestant6 - (bitllet5 * billeteCount);
                                        billeteCount = 0;
                                        for (int i = 0; i < preuRestant7; i += moneda2)
                                        {
                                            billeteCount++;
                                        }
                                        if ((billeteCount * moneda2) == preuRestant7)
                                        {
                                            Console.WriteLine(billeteCount + " MONEDA DE 2");
                                        }
                                        else
                                        {
                                            billeteCount--;
                                            Console.WriteLine(billeteCount + " MONEDA DE 2");
                                            int preuRestant8 = preuRestant7 - (moneda2 * billeteCount);
                                            billeteCount = 0;
                                            for (int i = 0; i < preuRestant8; i += moneda1)
                                            {
                                                billeteCount++;
                                            }
                                            if ((billeteCount * moneda1) == preuRestant8)
                                            {
                                                Console.WriteLine(billeteCount + " MONEDA DE 1");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            

        }
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

       
    }
}
