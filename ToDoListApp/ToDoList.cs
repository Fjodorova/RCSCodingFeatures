using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class ToDoList
    {
        //konstruktors, kur tiek izsaukts, kad tiek izveidots objekts. Konstruktors nekad neko neatgriež, un vienmér saucas tá pat ká klase.
        public ToDoList()
        {
            toDoEntries = new List<TodoListEntry>();
        }
        List<TodoListEntry> toDoEntries;

        public void AddNewToDo(string task)
        {
            //ja vizuālā studija nevar atrast klasi, uzspiežam Ctrl.(dote)
            Console.WriteLine("Uzdevums pievienots:" + task);
            TodoListEntry usersTodo = new TodoListEntry();
            usersTodo.Name = task;
            toDoEntries.Add(usersTodo);
        }

        public void ShowAllToDos()
        {
            //izvelkam pirmo elementu no saraksta izmantojot indekatoru
            //skaitītājs vienāds + 1; it tas pats, kas +=1;
            //tas pats, kas skaitītājs ++;
            //i ir saīsinājums no vārda index, intex latviešu valodā nozīmē skaitītājs;
            for (int i = 0; i < toDoEntries.Count; i++)
            {
                Console.Write((i + 1) + "Your To Do List entry is:" + toDoEntries[i].Name);
                if (toDoEntries[i].IsCompleted)
                {
                    Console.Write("Done!");
                }
                Console.WriteLine();
            }
        }

        public void deleteToDo(int indexOfToDo)
        {
            if (indexOfToDo >= this.toDoEntries.Count)
            {
                Console.WriteLine("Tāds ieraksts neeksistē!");
                return;
            }
            toDoEntries.RemoveAt(indexOfToDo);
        }

        public void MarkTodoAsDone(int doneToDoIndex)
        {
            toDoEntries[doneToDoIndex].IsCompleted = true;
        }

        public void deleteAllToDos()
        {
            toDoEntries.Clear();
        }

        public string pathToDoFile = @"C: \Users\selfishscream\Desktop\To Do List\todos.txt";

        internal void SaveToFile()
        {
            File.Delete(pathToDoFile);
            //Ctrl ar .
            for (int i = 0; i < toDoEntries.Count; i++)
            {
                string nameOfTodo = toDoEntries[i].Name;
                File.AppendAllText(pathToDoFile, nameOfTodo + "\r\n");
                bool isCompleted = toDoEntries[i].IsCompleted;
                File.AppendAllText(pathToDoFile, isCompleted + "\r\n");
            }
        }
        public void LoadFromFile()
        {
            if (!File.Exists(pathToDoFile))
            {
                return;
            }
            string[] allLinesFromFile = File.ReadAllLines(pathToDoFile);
            toDoEntries.Clear();
            for (var index = 0; index < allLinesFromFile.Length; index +=2)
            {
                string listEntry = allLinesFromFile[index];
                TodoListEntry fileTodo = new TodoListEntry();
                fileTodo.Name = listEntry;
                fileTodo.IsCompleted = bool.Parse(allLinesFromFile[index +1]);
                this.toDoEntries.Add(fileTodo);
            }
        }
    }
}
