// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//public static string[] ReadAllLines(string backers.txt);

string backersPath = "backers.txt";

//Ask player to insert name.

Console.WriteLine("Enter name");

string playerName = Console.ReadLine();

// Open the file to read from.
//Load all backer names into an array of strings.
string[] backerNames = File.ReadAllLines(backersPath);

//Display to the player whether they can enter the special area or not.
string foundName = Array.Find(backerNames, backerName => playerName == backerName);

if (foundName != null)
{
    Console.WriteLine("Congratulations, you are on the white list.");

}
else
{
    Console.WriteLine("You are not on the white list.");
}