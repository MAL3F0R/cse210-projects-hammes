using System;
using System.ComponentModel;

public class TerminalManager
{
    static string WelcomeMenu()
    {
        Console.WriteLine(@"
Welcome! Please select an option:
-------------------------------------
1. New Journal
2. Load Journal
3. Quit
Your selection:  ");

        string JselectionString = Console.ReadLine();
        return JselectionString;
    }

    static string JournalPropt()
    {
        Console.WriteLine(@"
Entry Menu:
-------------------------------------
1. New Entry
2. Load Entries
3. Change Journal
4. Quit 
        
Your Entry:  ");

        string EntryChoice = Console.ReadLine();
        return EntryChoice;
    }

    static void Main(string[] args)
    {   
        bool KeepLooping = true;

        while (KeepLooping == true)
        {
            bool LoadSelection = false;
            bool EntrySelection = false;

            string MenuChoice = WelcomeMenu();
            int SelectionInt = int.Parse(MenuChoice);

            while (LoadSelection == false)
            {
                if (SelectionInt == 1)
                {
                    Console.WriteLine("Provide a name for your new Journal: ");
                    string NewJournalName = Console.ReadLine();
                    FileManager.CreateJournal(NewJournalName);
                    LoadSelection = true;
                }
                else if (SelectionInt == 2)
                {
                    Console.WriteLine("Existing Journals: ");
                    List<string> allJournals = FileManager.GetAllJournals();
                    foreach (String journal in allJournals)
                    {
                        Console.WriteLine(" - " + journal);
                    }
                    string journalName;
                    do
                    {
                        Console.Write("Choose as journalName to open: ");
                        journalName = Console.ReadLine();
                    } 
                    while (!FileManager.FileExists(journalName));
                    FileManager.OpenJournal(journalName);
                    LoadSelection = true;
                }
                else if (SelectionInt == 3)
                {
                    LoadSelection = true;
                    Console.WriteLine("Exiting Application...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option picked");
                }
            }

            string JournalChoice = JournalPropt();
            int EntryInt = int.Parse(JournalChoice);

            while (EntrySelection == false)
            {
                if (EntryInt == 1)
                {
                    Console.WriteLine("New Journal Entry: ");
                    string randomPrompt = Promptor.GeneratePrompt();
                    Console.WriteLine("Journal Prompt: " + randomPrompt);
                    string promptResponse = Console.ReadLine();
                    DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                    Dictionary<string, string> entry = new Dictionary<string, string>();

                    entry["Date"] = currentDate.ToString();
                    entry["Prompt"] = randomPrompt;
                    entry["Text"] = promptResponse;

                    FileManager.SaveEntry(entry);
                    EntrySelection = true;
                }
                else if (EntryInt == 2)
                {
                    Console.WriteLine(FileManager.journal);
                    Console.Write("Hit ENTER");
                    Console.ReadLine();
                    EntrySelection = true;
                }
                else if(EntryInt == 3)
                {
                    Console.WriteLine("Returning to journal menu...");
                    EntrySelection = true;
                }
                else if (EntryInt == 4)
                {
                    EntrySelection = true;
                    Console.WriteLine("Exiting Application...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Entry choice");
                }
            }
        }
    }
}