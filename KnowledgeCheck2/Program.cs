using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userInput = string.Empty;
            var wizardList = new List<Wizard>();
            while (userInput != "exit")
            {
                Console.WriteLine("Press 1 to add Wizard");
                Console.WriteLine("Press 2 to view the Wizards");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "1")
                {
                    Console.WriteLine("How many Wizards do you want to add? ");
                    var numberOfWizards = int.Parse(Console.ReadLine());


                    for (int i = 0; i < numberOfWizards; i++)
                    {
                        
                        var wizard = new Wizard();

                        Console.WriteLine("Enter the Wizard Name");
                        wizard.Name = Console.ReadLine();
                        Console.WriteLine("Enter the Wizard Mana Level");
                        wizard.Manalevel = int.Parse(Console.ReadLine());

                        wizardList.Add(wizard);
                    }

                }
                if (userInput == "2")
                {
                    foreach (var wizard in wizardList)
                    {
                        Console.WriteLine(wizard.Name);
                        Console.WriteLine(wizard.Manalevel);
                    }
                    
                }


            }


        }
    }
}
