using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList list = new ToDoList();


            while (true)
            {
                Console.WriteLine("Lūdzu izvēlieties darbību:");
                Console.WriteLine("a - pievienot");
                Console.WriteLine("p - parādīt");
                Console.WriteLine("d - dzēst");
                Console.WriteLine("at - izdarīts");
                Console.WriteLine("c - dzēst visu");
                Console.WriteLine("s - saglabāt");
                Console.WriteLine("l - ielādēt");
                string usersInput = Console.ReadLine();
                switch (usersInput)
                {
                    case "pievienot":
                    case "a":
                        Console.WriteLine("Lūdzu ievadiet darāmo lietu skaitu:");
                        string toDoTask = Console.ReadLine();
                        list.AddNewToDo(toDoTask);
                        break;
                    case "print":
                    case "p":
                        list.ShowAllToDos();
                        break;
                    case "at":
                        Console.WriteLine("Lūdzu ievadi pabeigtā uzdevuma numuru.");
                        list.ShowAllToDos();
                        int doneToDoIndex = int.Parse(Console.ReadLine());
                        list.MarkTodoAsDone(doneToDoIndex - 1);
                        break;
                    case "d":
                        Console.WriteLine("Lūdzu ievadi dzēšamo numuru");
                        list.ShowAllToDos();
                        int index = int.Parse(Console.ReadLine());
                        list.deleteToDo(index - 1);
                        break;
                    case "c":
                        Console.WriteLine("Vai vēlies izdzēst visu sarakstu? jā/nē");
                        list.deleteAllToDos();
                        break;
                    case "s":
                        list.SaveToFile();
                        break;
                    case "l":
                        list.LoadFromFile();
                        break;
                    default:
                        Console.WriteLine("Neatpazina komandu!");
                        break;
                }
            }
        }
    }
}
