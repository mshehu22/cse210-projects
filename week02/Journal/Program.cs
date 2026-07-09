using System;

/*
Creativity:
- Added 10 journal prompts instead of the required 5.
- Displays the total number of journal entries after showing them.
*/

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                if (System.IO.File.Exists(file))
                {
                    journal.LoadFromFile(file);
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }

            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }

            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}