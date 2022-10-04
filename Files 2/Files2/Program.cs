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
//Alternative solution: string foundName = Array.Find(backerNames, backerName => playerName == backerName);

bool isOnWhiteList = false;
foreach (string backerName in backerNames)
{
    if (playerName == backerName)
    {
        isOnWhiteList = true;
    }

}

if (isOnWhiteList)
{
    Console.WriteLine("Congratulations, you are on the white list.");

}
else
{
    Console.WriteLine("You are not on the white list.");
}