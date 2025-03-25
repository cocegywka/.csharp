using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> tasks = new Queue<string>();
    static Stack<string> urgentTasks = new Stack<string>();

    static void AddTask(string task)
    {
        tasks.Enqueue(task);
        Console.WriteLine($"Добавлена задача: {task}");
    }
    static void CompleteTasks()
    {
        if (tasks.Count > 0)
        {
            string completeTask = tasks.Dequeue();
            Console.WriteLine($"Выполнена задача: {completeTask}");
        }
        else
        {
            Console.WriteLine("Задач нет");
        }
    }
    static void AddUrgentTask(string task)
    {
        urgentTasks.Push(task);
        Console.WriteLine($"Добавлена срочная задача: {task}");
    }
    static void CompleteUrgentTask()
    {
        if (urgentTasks.Count > 0)
        {
            string completeTask = urgentTasks.Pop();
            Console.WriteLine($"Выполнена срочная задача: {completeTask}");
        }
        else
        {
            Console.WriteLine("Срочных задач нет");
        }
    }

    static void completeAllTasks() 
    {
        while (tasks.Count > 0) CompleteTasks();
        while (urgentTasks.Count > 0) CompleteUrgentTask();
    }
    static void PrintTasks()
    {
        if (tasks.Count == 0 && urgentTasks.Count == 0)
        {
            Console.WriteLine("Нет текущих задач.");
        }
        else
        {
            Console.WriteLine($"Текущие задачи:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task}");
            }
            Console.WriteLine($"Текущие срочные задачи:");
            foreach (var task in urgentTasks)
            {
                Console.WriteLine($"{task}");
            }
        }
        
    }
    static void Main()
    {
        AddTask("Что то сделать 1");
        AddTask("Что то сделать 2");
        AddTask("Что то сделать 3");
        AddUrgentTask("Что то срочное 1");
        AddUrgentTask("Что то срочное 2");
        
        
        CompleteTasks();
        CompleteUrgentTask();

        // completeAllTasks();

        PrintTasks();
    }
}