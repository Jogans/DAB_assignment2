using DAB_Assignment_2.Models;
using DAB_Assignment_2.DAL;
using System;

namespace DAB_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                DbInitializer init = new DbInitializer();
                init.Initialize(db);
                Views view = new Views();
                System.Console.WriteLine("Det gik godt");

                Console.Write("\t\t Velkommen til WhereToEat\n");

                Console.Write("Indtast et tal mellem 1 og 3 for at vælge den valgte metode\n");

                int valg = Console.Read();

                if (valg == 1)
                {
                    Console.Write("Du har valgt Metode A");
                    Console.Write("Vælg ud fra typen af Restaurant");
                    Console.Write("De mulige Typer er:");
                    Console.Write("\t 1: Dessert \n");
                    Console.Write("\t 2: Dinner \n");
                    Console.Write("\t 3: Breakfast \n");
                    Console.Write("\t 4: Lunch \n");

                    int valg1 = Console.Read();

                    if (valg1 == 1)
                    { view.MethodA("Dessert", db); }

                    if (valg1 == 2)
                    { view.MethodA("Dinner", db); }

                    if (valg1 == 3)
                    { view.MethodA("Breakfast", db); }

                    if (valg1 == 4)
                    { view.MethodA("Lunch", db); }

                    else
                    {
                        Console.Write("Prøv igen");
                    }
                }

                if (valg == 2)
                {
                    Console.Write("Du har valgt Metode B");
                    Console.Write("Vælg ud fra adressen af Restaurant");
                    Console.Write("De mulige adresser er:");
                    int counter = 1;


                    foreach (var adresse in db.Restaurants)
                    {
                        
                        Console.Write("\t {0}: {1} \n",counter, adresse.Address);
                        counter++;
                    }

                    Console.Write("Indtast et tal mellem 1 og 8");

                    int valg2 = Console.Read();

                    switch (valg2)
                    {
                        case 1:
                            view.MethodB("Mordor Lane 35", db);
                            break;
                        case 2:
                            view.MethodB("Fast Food Road 88", db);
                            break;
                        case 3:
                            view.MethodB("Candy Way 15", db);
                            break;
                        case 4:
                            view.MethodB("Growl Hill 32", db);
                            break;
                        case 5:
                            view.MethodB("Fancy Boulevard", db);
                            break;
                        case 6:
                            view.MethodB("Early Bird 75", db);
                            break;
                        case 7:
                            view.MethodB("Strange Green 2", db);
                            break;
                        case 8:
                            view.MethodB("Sleepy Road 14", db);
                            break;
                        default:
                            Console.Write("Prøv igen, Indtast et tal mellem 1 og 8");
                            break;
                    }


                }

                if (valg == 3)
                {
                    Console.Write("Du har valgt Metode C");
                    Console.Write("Vælg ud fra adressen af Restaurant");
                    Console.Write("De mulige adresser er:");
                    int counter = 1;


                    foreach (var adresse in db.Restaurants)
                    {

                        Console.Write("\t {0}: {1} \n", counter, adresse.Address);
                        counter++;
                    }

                    Console.Write("Indtast et tal mellem 1 og 8");

                    int valg2 = Console.Read();

                    switch (valg2)
                    {
                        case 1:
                            view.MethodC("Mordor Lane 35", db);
                            break;
                        case 2:
                            view.MethodC("Fast Food Road 88", db);
                            break;
                        case 3:
                            view.MethodC("Candy Way 15", db);
                            break;
                        case 4:
                            view.MethodC("Growl Hill 32", db);
                            break;
                        case 5:
                            view.MethodC("Fancy Boulevard", db);
                            break;
                        case 6:
                            view.MethodC("Early Bird 75", db);
                            break;
                        case 7:
                            view.MethodC("Strange Green 2", db);
                            break;
                        case 8:
                            view.MethodC("Sleepy Road 14", db);
                            break;
                        default:
                            Console.Write("Prøv igen, Indtast et tal mellem 1 og 8");
                            break;
                    }

                }

                //    view.MethodA("Dessert", db);
                //view.MethodA("Lunch", db);
                //view.MethodA("Dinner", db);
                //view.MethodB("Candy Way 15", db);
                //view.MethodC("Growl Hill 32", db);
                //view.MethodC("Fancy Boulevard 1", db);
                //view.MethodC("Mordor Lane 35", db);
                //Console.WriteLine("1");
                //foreach (var rest in db.Restaurants)
                //{
                //    Console.WriteLine($"{rest.Address}");
                //}
            }
        }
    }
}