using System;
using System.Collections.Generic;
using System.Text;

namespace Multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();

            string input = "";
            var car = new Cars();
            var candy = new Sweets();
            var pipe = new Pipes();
            var milk = new Milks();

            var carsList = new List<object>();
            var sweetsList = new List<object>();
            var pipesList = new List<object>();
            var milksList = new List<object>();

            while(true) {
                switch(Console.ReadKey(true).Key) {
                    case ConsoleKey.D1:
                        Header();
                        car.Form(input);
                        car.Confirmation();
                        carsList.Add(car.Item());
                        break;

                    case  ConsoleKey.D2:
                        Header();
                        candy.Form(input);
                        candy.Confirmation();
                        sweetsList.Add(candy.Item());
                        break;

                    case  ConsoleKey.D3:
                        Header();
                        pipe.Form(input);
                        pipe.Confirmation();
                        pipesList.Add(pipe.Item());
                        break;

                    case  ConsoleKey.D4:
                        Header();
                        milk.Form(input);
                        milk.Confirmation();
                        milksList.Add(milk.Item());
                        break;

                    case  ConsoleKey.D5:
                        string text;
                        Header();
                        text = "Beställda bilar: ";
                        ShowItems(text, carsList);
                        
                        text = "\nBeställda godis: ";
                        ShowItems(text, sweetsList);
                        
                        text = "\nBeställda rör: ";
                        ShowItems(text, pipesList);

                        text = "\nBeställda havremjölk: ";
                        ShowItems(text, milksList);

                        ShowEmptyMsg(carsList, sweetsList, pipesList, milksList);
                        break;

                    case  ConsoleKey.D6:
                        return;
                        
                    default:
                        Header();
                        break;
                }
            }

        }

        static void Header() {
            Console.Clear();

            var builder = new StringBuilder();

            builder
                .Append('*', 50)
                .AppendLine("\n")
                .Append("\t\tMultifabriken AB")
                .AppendLine("\n")
                .Append('*', 50)
                .Append("\n[1] Bilar").AppendLine("\t\t[5] Lista produkter")
                .Append("[2] Godis").AppendLine("\t\t[6] Avsluta")
                .Append("[3] Rör\n")
                .Append("[4] Havremjölk\n")
                .Append('_', 50)
                .AppendLine("\n");
            
            Console.WriteLine(builder);

        }

        static void ShowItems(string text, List<object> list) {
            if (list.Count > 0) {
                Console.WriteLine(text);
                foreach(var n in list) Console.WriteLine("* " + n);
            } 
        }

        static void ShowEmptyMsg(List<object> list1, List<object> list2, List<object> list3, List<object> list4) {
            if  (list1.Count + list2.Count + list3.Count + list4.Count == 0){
                Console.WriteLine("Inga produkter har beställts!");
            }
        }
    }
}
