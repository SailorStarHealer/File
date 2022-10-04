//Define a variable playerNamePath with value "player-name.txt".
var playerNamePath = "playr-name.txt";


//If the file did exist, load the player name and greet the player by name.
if (File.Exists(playerNamePath))
{
    var playerTitle = File.ReadAllText(playerNamePath);

    Console.WriteLine($"Welcome back, {playerTitle}!");

}

else

//If the file with that path doesn't exist, welcome the player to the adventure and ask for a name.
{
    Console.WriteLine($"Welcome, fellow traveller! Please input thy name!");
    //Store the name the player enters into the file.
    string playerName = Console.ReadLine();

    //Store the name the player enters into the file.
    File.WriteAllText(playerNamePath, playerName);
}
//Store the name they enter into the file.