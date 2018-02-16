﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class ToDoList
    {
        //konstruktors, kur tiek izsaukts, kad tiek izveidots objekts. Konstruktors nekad neko neatgrie, un vienmér saucas tá pat ká klase.
        public ToDoList()
        {
            toDoEntries = new List<string>();
        }
        List<string> toDoEntries;

        public void AddNewToDo(string task)
        {
            //ja vizuālā studija nevar atrast klasi, uzspiežam Ctrl.(dote)
            Console.WriteLine("Uzdevums pievienots:" + task);
            toDoEntries.Add(task);
        }

        public void ShowAllToDos()
        {
            //izvelkam pirmo elementu no saraksta izmantojot indekatoru
            for (int skaitītājs = 0; skaitītājs < toDoEntries.Count; skaitītājs = skaitītājs + 1)
            {
                Console.WriteLine("Your To Do List entry is:" + toDoEntries[skaitītājs]);
            }
        }

    }
}