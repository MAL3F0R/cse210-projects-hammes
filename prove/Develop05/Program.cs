using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

public class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }

    public virtual void Complete()
    {
        Console.WriteLine($"Goal '{Name}' completed! Earned {Points} points.");
    }
}

public class EternalGoal : Goal
{
    public int amount { get; set; }

    public override void Complete()
    {
        base.Complete();
        Console.WriteLine($"Completed Eternal Goal {amount} of times.");
    }
}

// Class to represent user profile
public class UserProfile
{
    public string UserName { get; set; }
    public int Level { get; set; }
    public int TotalPoints { get; set; }
    public List<Goal> CompletedGoals { get; set; } = new List<Goal>();

    public void RemoveGoal(string goalName)
    {
        Goal goalToRemove = CompletedGoals.Find(g => g.Name == goalName);

        if (goalToRemove != null)
        {
            CompletedGoals.Remove(goalToRemove);
            Console.WriteLine($"Goal '{goalName}' removed from {UserName}'s profile.");
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found in {UserName}'s profile.");
        }
    }
}

public class Program
{
    static void Main()
    {   
        ClearConsole();
        bool keepLooping;
        keepLooping = true;
        while(keepLooping)
        {
            Console.WriteLine(@"Welcome to goal completion game! Please choose an option: 
1. Create New User
2. Display User
3. Load selected user/update goal progress
4. Remove User
5. Exit Application
Your selection: ");
            string userSelection = Console.ReadLine();
            
            int userInt = int.Parse(userSelection);

            switch(userInt)
            {
                case 1:
                    ClearConsole();
                    Console.WriteLine("\nPlease give a name for the new user you wish to create: ");
                    string newUser = Console.ReadLine();
                    AddUser(new UserProfile { UserName = newUser });
                break;
                
                case 3:
                    ClearConsole();
                    List<UserProfile> userProfiles = LoadUsers();
                    foreach (var userProfile in userProfiles)
                        DisplayUserProfile(userProfile);
                    Console.Write("Enter the username to select a profile: ");
                    string selectedUsername = Console.ReadLine();
                    UserProfile selectedUserProfile = userProfiles.Find(u => u.UserName == selectedUsername);
                    if (selectedUserProfile != null)
                    {
                        PerformActions(selectedUserProfile);
                    }
                    else
                    {
                        Console.WriteLine("\nUser profile not found. Please enter a valid name.");
                    }
                        break;

                case 4:
                    ClearConsole();
                    Console.WriteLine("\nWhat is the name of the user you want to remove: ");
                    string removeUser = Console.ReadLine();
                    RemoveUser(removeUser);
                break;

                case 5:
                    ClearConsole();
                    Console.WriteLine("Exiting Apllication...");
                    keepLooping = false;
                    Environment.Exit(0);
                break;

            }
        }
    }

    static void ClearConsole()
    {
        Console.Clear();
    }

    static void PerformActions(UserProfile userProfile)
    {
        ClearConsole();
        Console.WriteLine(@"\nWhat do you wish to do with this profile: 
1. Add a goal
2. Add Eternal Goal 
3. Redeem Goal");
        int profileSelection = int.Parse(Console.ReadLine());

        switch(profileSelection)
        {
            case 1:
                Console.WriteLine("What is the name of this goal: ");
                string goalName = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth: ");
                int pointAmount = int.Parse(Console.ReadLine());
                Goal newGoal = new Goal { Name = $"{goalName}", Points = pointAmount};
                userProfile.CompletedGoals.Add(newGoal);
            break;

            case 2:
                Console.WriteLine("What is the name of this goal: ");
                string eternalGoalName = Console.ReadLine();
                Console.WriteLine("How many points is this goal worth: ");
                int eternalPointAmount = int.Parse(Console.ReadLine());
                EternalGoal newEternal = new EternalGoal { Name = $"{eternalGoalName} (Eternal Goal)", Points = eternalPointAmount, amount = 0 };
                userProfile.CompletedGoals.Add(newEternal);
                DisplayUserProfile(userProfile);
            break;

            case 3:
                Console.WriteLine("What is the name of the goal you want to redeem: ");
                string inputName = Console.ReadLine();
                userProfile.RemoveGoal(inputName);
                Goal completedGoal = new Goal { Name = $"{inputName} (Complete Goal)", Points = 0};

            break;

        }
    }

    static void UpdateUserProfileList(List<UserProfile> userProfiles)
    {
       // Update user profile properties based on completed goals for all users
        foreach (var userProfile in userProfiles)
        {
            foreach (var goal in userProfile.CompletedGoals)
            {
                userProfile.TotalPoints += goal.Points;
            }
            userProfile.Level = userProfile.TotalPoints / 100;
        }
    }


    static void DisplayUserProfile(UserProfile userProfile)
    {
        Console.WriteLine($"User: {userProfile.UserName}");
        Console.WriteLine($"Level: {userProfile.Level}");
        Console.WriteLine($"Total Points: {userProfile.TotalPoints}");
        Console.WriteLine("Completed Goals:");
        
        foreach (var goal in userProfile.CompletedGoals)
        {
            Console.WriteLine($"{goal.Name} - {goal.Points} points");
        }
    }

    static void AddUser(UserProfile newUser)
    {
        // Load existing users from the JSON file
        List<UserProfile> existingUsers = LoadUsers();

        // Add the new user
        existingUsers.Add(newUser);

        // Save the updated list of users to the JSON file
        SaveUsers(existingUsers);
    }

    static void RemoveUser(string usernameToRemove)
    {
        // Load existing users from the JSON file
        List<UserProfile> existingUsers = LoadUsers();

        // Remove the user with the specified username
        UserProfile userToRemove = existingUsers.Find(u => u.UserName == usernameToRemove);
        if (userToRemove != null)
        {
            existingUsers.Remove(userToRemove);

            // Save the updated list of users to the JSON file
            SaveUsers(existingUsers);
        }
        else
        {
            Console.WriteLine($"User with username '{usernameToRemove}' not found.");
        }
    }

    static List<UserProfile> LoadUsers()
    {
        // Load users from a JSON file
        string filePath = "userProfiles.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<UserProfile>>(json);
        }

        return new List<UserProfile>();
    }

    static void SaveUsers(List<UserProfile> users)
    {
        // Save the list of users to a JSON file
        string filePath = "userProfiles.json";
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }
}
