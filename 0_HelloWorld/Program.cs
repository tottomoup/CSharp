//Change appearance of Console
//Presentation
Console.Title = "Welcome";
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("--------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("         My Home");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("--------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WindowHeight = 40;

Console.WriteLine("Welcome to my home, what is your name?");
string myString = Console.ReadLine();

Console.WriteLine("Hi " + myString + " do you want to play a game");
string playgame = Console.ReadLine();

if(playgame == "yes"){
Console.WriteLine("Nice, do you want to play a boardgame or a videogame?");
    string game = Console.ReadLine();
    if(game == "boardgame"){
        Console.WriteLine("Ok, i got Among Us The Game, and Monopoly and Sussy Imposter");
        string whatBoardgame = Console.ReadLine();
            if(whatBoardgame == "Among Us The Game"){
                Console.WriteLine("I am the best at Among Us The Game");
            }
        else if(whatBoardgame == "Monopoly"){
            Console.WriteLine("Yeah i like this game");
        }
        else{
            Console.WriteLine("Ok im ok at Sussy Imposter");
        }
    }
    else{
        Console.WriteLine("Ok, i got Among us and Stick Fight and Minecraft. Which one do you want to play?");
    }
    string whatGame = Console.ReadLine();
    if(whatGame == "Among us"){
        Console.WriteLine("Among us wooooooooooo");
    }
    else if(whatGame == "Stick Fight"){
        Console.WriteLine("OkOk Stick Fight it is");
        Console.WriteLine("Type 'Start' to start the game");
        string startGame = Console.ReadLine();
            if(startGame == "Start"){
                Console.WriteLine("press 1, 2 or 3 to see if you win!");
            }
    }
    else{
        Console.WriteLine("Ok, Minecraft it is :)");  
    }
}
else{
    Console.WriteLine("Do you then want to eat anything?");
        string food = Console.ReadLine();
        if(food == "yes"){
            Console.WriteLine("Ok, i got Pizza, Burger, Soup and Breade. Which one do you want to eat?");
        }
        else{
            Console.WriteLine("Bruh");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
}


Console.ReadLine();
