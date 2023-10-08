using System;
using System.ComponentModel;
using System.IO;

public class FileManager
{
    public const string JournalFolder = "Journals/";
    public static string JournalPath;
    public static string journal;

    public static List<string> GetAllJournals()
    {
        List<string> fileNames = Directory.GetFiles(JournalFolder, "*.json").ToList<string>();

        for (int i = 0; i < fileNames.Count; i++)
        {
            string fileName = fileNames[i];
            fileName = fileName.Replace(JournalFolder, "");
            fileName = fileName.Replace(".json", "");
            fileNames[i] = fileName;
        }

        return fileNames;
    }

    public static bool FileExists(string fileName)
    {
        string path = JournalFolder + fileName + ".json";
        return File.Exists(path);
    }
    
    public static void OpenJournal(string journalName)
    {
        if (!FileExists(journalName))
        {
            return;
        }
        JournalPath = journalName;
        string path = JournalFolder + JournalPath + ".json";
        journal = File.ReadAllText(path);
    }

    public static void CreateJournal(string journalName)
    {
        journal = "";
        string path = JournalFolder + journalName;

        if (!FileExists(journalName))
        {
            JournalPath = journalName;
            path = path + ".json";
            File.WriteAllText(path, "");

            return;
        }

        int j = 0;
        while (true)
        {
            j++;
            if (FileExists(journalName + j.ToString()))
            {
                break;
            }
        }

        JournalPath = journalName + j.ToString();
        path = path + j.ToString() + ".json";
        File.WriteAllText(path, "");
    }

    public static void SaveEntry(Dictionary<string, string> entryDict)
    {
        string entry = $"\nDate of entry: {entryDict["Date"]} - Given Prompt: {entryDict["Prompt"]}\n";
        entry += $"{entryDict["Text"]}\n";
        journal += entry;
        string path = JournalFolder + JournalPath + ".json";
        File.WriteAllText(path, journal);

    }
}