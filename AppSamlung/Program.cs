using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSamlung
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int caseSwitch = 0;

            while (run)
            {
                Console.WriteLine("App Samlung:");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Temperatur Umrechner");
                Console.WriteLine("2. Mittelwertrechner");
                Console.WriteLine("3. BMI Rechner");
                if (int.TryParse(Console.ReadLine(), out caseSwitch) && caseSwitch <= 3 && caseSwitch != 0)
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Falsche Eingabe!");
                    Console.WriteLine("Geben Sie Bitte nur 1, 2 oder 3 ein!");
                    Console.ReadLine();
                }
                switch (caseSwitch)
                {
                    case 1:
                        TemperaturRecher();
                        break;
                    case 2:
                        Mittelwert();
                        break;
                    case 3:
                        Bmi();
                        break;
                }
            }
        }

        static void TemperaturRecher()
        {
            double temperature = 0.0;
            int caseSwitch = 0;
            bool go = true;

            while (go)
            {
                Console.WriteLine("Umrechner Temperatur");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Celsius zu Fahernheit.");
                Console.WriteLine("2. Fahrenheit zu Celsius.");
                Console.WriteLine("Geben Sie eine Zahl an: ");
                if (int.TryParse(Console.ReadLine(), out caseSwitch))
                {
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Falsche Eingabe!");
                    Console.WriteLine();
                }
                if (caseSwitch <= 2 && caseSwitch != 0)
                {
                    switch (caseSwitch)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Celsius zu Fahernheit.");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Geben Sie ein Wert an: ");
                            if (double.TryParse(Console.ReadLine(), out temperature))
                            {
                                temperature = 9 / 5 * temperature + 32;
                                Console.WriteLine("Eingegebene Temperatur in Fahreneit: " + temperature + "°F");
                                Console.ReadLine();
                                go = false;

                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Falsche Eingabe!");
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Fahrenheit zu Celsius.");
                            Console.WriteLine("---------------------------");
                            Console.WriteLine("Geben Sie ein Wert an: ");
                            if (double.TryParse(Console.ReadLine(), out temperature))
                            {
                                temperature = 5 / 9 * temperature - 32;
                                Console.WriteLine("Eingegebene Temperatur in Celsius: " + temperature + "°C");
                                Console.ReadLine();
                                go = false;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Falsche Eingabe!");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geben Sie 1 oder 2 an!");
                }
            }
        }

        static void Mittelwert()
        {
            int zahl = 0;
            decimal ergebnis;
            String eingabe;
            int zaehler = 0;
            int gesamtwert = 0;
            bool done = false;

            Console.WriteLine("Geben Sie eine Null zum Beenden ein!");
            do
            {
                Console.WriteLine("Geben Sie eine Zahl an: ");
                eingabe = Console.ReadLine();
                Console.Clear();
                int.TryParse(eingabe, out zahl);
                if (zahl == 0)
                {
                    if (eingabe != 0.ToString())
                    {
                        Console.WriteLine("Keine Zahl!");
                    }
                    else
                    {
                        done = true;
                    }
                }
                else
                {
                    zaehler++;
                    gesamtwert += zahl;
                    ergebnis = gesamtwert / zaehler;
                    Console.WriteLine("Der Mittelwert ist: " + ergebnis);
                }
                Console.WriteLine("---------------------------");
            } while (!done);
        }

        static void Bmi()
        {
            String eingabe = "";
            Char geschlecht = 'm';
            double kg = 0.0;
            double m = 0.0;
            double bmi = 0.0;

            Console.WriteLine("BMI Rechner");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Geben Sie ihr Körpergewicht an: ");
            eingabe = Console.ReadLine();
            double.TryParse(eingabe, out kg);
            Console.Clear();
            Console.WriteLine("BMI Rechner");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Geben Sie ihre Größe an: ");
            eingabe = Console.ReadLine();
            double.TryParse(eingabe, out m);
            Console.Clear();
            Console.WriteLine("BMI Rechner");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Geben Sie ihr Geschlecht an mit m/w: ");
            eingabe = Console.ReadLine();
            Char.TryParse(eingabe, out geschlecht);
            Console.Clear();
            bmi = kg / (Math.Pow(m, 2));
            if (geschlecht == 'm')
            {
                Console.WriteLine("Ihr BMI beträgt: " + bmi);
                Console.WriteLine("---------------------------");
                if (bmi <= 20)
                {
                    Console.WriteLine("Untergewichtig");
                }
                else if (bmi <= 25)
                {
                    Console.WriteLine("Normalgewicht");
                }
                else if (bmi <= 30)
                {
                    Console.WriteLine("Übergewicht");

                }
                else if (bmi <= 40)
                {
                    Console.WriteLine("Adipositas");
                }
                else
                {
                    Console.WriteLine("massives Adipositas");
                }
            }
            else if (geschlecht == 'w')
            {
                Console.WriteLine("Ihr BMI beträgt: " + bmi);
                Console.WriteLine("---------------------------");
                if (bmi <= 19)
                {
                    Console.WriteLine("Untergewichtig");
                }
                else if (bmi <= 24)
                {
                    Console.WriteLine("Normalgewicht");
                }
                else if (bmi <= 30)
                {
                    Console.WriteLine("Übergewicht");

                }
                else if (bmi <= 40)
                {
                    Console.WriteLine("Adipositas");
                }
                else
                {
                    Console.WriteLine("massives Adipositas");
                }
            }
            else
            {
                Console.WriteLine("Kein Geschlecht!");
            }
        }
    }
}