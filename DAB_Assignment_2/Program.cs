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
                //DbInitializer init = new DbInitializer();
                //init.Initialize(db);
                //System.Console.WriteLine("Det gik godt");
                Views view = new Views();
                view.MethodA("Dessert", db);
                view.MethodA("Lunch", db);
                view.MethodC("Candy Way 15", db);
                view.MethodC("Growl Hill 32", db);
                view.MethodC("Fancy Boulevard 1", db);
                view.MethodC("Mordor Lane 35", db);
                //Console.WriteLine("1");
                //foreach (var rest in db.Restaurants)
                //{
                //    Console.WriteLine($"{rest.Address}");
                //}
            }
        }
    }
}