// See https://aka.ms/new-console-template for more information
Console.WriteLine("Furniture Store");
using System;
using System.Collections.Generic; // Using directives outside the namespace

namespace HcH840_FurnitureApp
{
    public class Furniture
    {
        public string Mark { get; set; }
        public string Type { get; set; }
        public string Year { get; set; } // Declare Furniture specs (Mark, type:chair, table, dresser... , year of Production dd/mm/yy format) 
        public Furniture(string mark, string type, string year)
        {
            Mark = mark; Type = type; Year = year;
        } // with Furniture(); write classname.attributename ex: frt.Mark = ...
    }
    internal class Program
    {
        List<Furniture> list = new List<Furniture>(); // create Furniture Arraylist with <>
        public void createitem()
        {
            Console.WriteLine("Enter Mark:");
            string mark = Console.ReadLine();
            Console.WriteLine("Enter Item Type:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Item Production Year:");
            string year = Console.Readline();
            Furniture frt = new Furniture(mark, type, year);
            list.Add(frt);
        } // method to add new item on store
        public void deleteitem()
        {
            Console.WriteLine("Enter Item Type for deletion.");
            string type = Console.Readline();
            Furniture frt = list.Find(frt => frt.Type == type); // Find item in list by type
            if (frt != null)
            {
                list.Remove(frt);
                Console.WriteLine("Item is deleted.");
            }
            else Console.WriteLine("Item not found.");
        } // method to remove item based on type if exists
        public void updateitem()
        {
            Console.WriteLine("Enter Item Mark to Modify!");
            string mark = Console.ReadLine();
            Furniture frt = list.Find(frt => frt.Mark == mark); // Find item in list by mark
            if (frt != null)
            {
                Console.WriteLine("Enter new Item Specs!");
                Console.WriteLine("Enter new Item Type:");
                frt.Type = Console.ReadLine();
                Console.WriteLine("Enter Item Production Year:");
                frt.Year = Console.Readline();
            }
            else Console.WriteLine("Item does not exist to modify.");
        } // method to modify item by mark if exists
        public void ListItem()
        {
            foreach (Furniture x in list)
            {
                Console.WriteLine("Enter Mark: " + x.Mark);
                Console.WriteLine("Enter Item Type: " + x.Type);
                Console.WriteLine("Enter Item Production Year: " + x.Year);
            } // for each item in the list, this method displays its specs 
        } // List Items in the Store
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Desired Case!");
                int choice = Convert.ToInt32(Console.Readline());
                    switch (choice){
                    case 1:
                        Console.WriteLine("Case 1 - Create Item.");
                        createitem();
                        break;
                    case 2:
                        Console.WriteLine("Case 2 - Delete Item.");
                        deleteitem();
                        break;
                    case 3:
                        Console.WriteLine("Case 3 - Update Item.");
                        updateitem();
                        break;
                    case 4:
                        Console.WriteLine("Case 4 - List Items.");
                        ListItem();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!");
                        break;
                }
                                                }
                                        }
                                }
                        }
