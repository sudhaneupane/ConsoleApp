using System;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To Do List");
            List<string> taskList = new List<string>();
            string option = "";

            while(option != "e")
            {
                Console.WriteLine("What would you like to do");
                Console.WriteLine("Enter 1 to add task to the list");
                Console.WriteLine("Enter 2 to delete task form the List");
                Console.WriteLine("Enter 3 to view the List");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("Please enter the task");
                    string task =Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the List");
                    Console.WriteLine();
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + ":" + taskList[i]);

                    }
                    Console.WriteLine("Please enter the number that you want to remove from the list");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current task in the List");
                    for (int i = 0; i <taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]) ;
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting program");
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            }
            Console.WriteLine("Thank You for using the program");
        }
    }
}