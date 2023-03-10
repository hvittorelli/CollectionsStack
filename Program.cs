using System;
using System.Collections.Generic;

namespace CollectionsStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> familyTree = new Stack<string>();
            familyTree.Push("Grandson");
            familyTree.Push("Daugter");
            familyTree.Push("Mom");
            familyTree.Push("Grandma");
            familyTree.Push("Grandpa");


            Console.WriteLine("Enter the name of the family member you want to search for: ");
            string familyMem = Console.ReadLine();
            if (familyTree.Contains(familyMem))
            {
                Console.WriteLine($"{familyMem} is included in the family tree!");
            }
            else
            {
                Console.WriteLine($"Sorry, {familyMem} isn't listed in the family tree!");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {familyTree.Count} members included in the family tree. Here are the members listed: ");
            foreach (string mem in familyTree)
            {
                Console.WriteLine(mem);
            }

            string firstMem = familyTree.Peek();
            Console.WriteLine();
            Console.WriteLine($"If you would like to remove {firstMem} enter Y? If not, press any key to continue");
            string answer = Console.ReadLine();
            while (answer == "Y")
            {
                familyTree.Pop();
                Console.WriteLine($"{firstMem} has been removed!");
                firstMem = familyTree.Peek();
                Console.WriteLine();
                Console.WriteLine($"If you would like to remove {firstMem} enter Y? If not, press any key to continue.");
                answer = Console.ReadLine();
            }
            if (familyTree.Peek() == null)
                Console.WriteLine("The tree is empty");
            else
            {
                Console.WriteLine($"There are {familyTree.Count} members left in the tree.");
                foreach (string mem in familyTree)
                {
                    Console.WriteLine(mem);
                }
            }
        }
    }
}
