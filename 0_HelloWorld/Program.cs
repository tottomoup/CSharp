﻿//Change appearance of Console
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
                Console.WriteLine("Hello welcome to among us");
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
        Console.WriteLine("Hello welcome to among us");
Console.WriteLine("Do you want to start");

string startGame = Console.ReadLine();
if (startGame == "yes")
{
    Console.WriteLine("Then we start");
}
else if (startGame == "no" )

{
    Console.WriteLine("then goodbye");
    Thread.Sleep(5000);
    Environment.Exit(0);
}
else
{
    Console.WriteLine( startGame + ", that is not yes or no you are very cringe");
    Thread.Sleep(5000);
    Environment.Exit(0);
} 

Console.WriteLine("Good then let the among us game begin!");
Thread.Sleep(1000);
Console.WriteLine("so what color do you want to be blue, red, green, yellow, black, white");

string farve = Console.ReadLine();
switch (farve) 
{
  case "blue":
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Then you are blue");
    break;
  case "red":
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("Then you are red");
    break;
  case "green":
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Then you are green");
    break;
  case "yellow":
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Then you are yellow");
    break;
  case "black":
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("Then you are black");
    break;
  case "white":
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Then you are white");
    break;
}

Console.WriteLine("You are an imposter");
Console.WriteLine("you see pink infront of you what do you do kill or walk by?");
string answer = Console.ReadLine();
    }
    else if(whatGame == "Stick Fight"){
        Console.WriteLine("OkOk Stick Fight it is");
        Console.WriteLine("Type 'Start' to start the game");
        string startGame = Console.ReadLine();
            if(startGame == "Start"){
                Console.WriteLine("Type a number between 1-10 to see if you win!");
             int value = Convert.ToInt32(Console.ReadLine());
             Random rnd = new Random();
            int number  = rnd.Next(1, 10);
           if(number == value){
              Console.WriteLine("You win");
            }
            else{
              Console.WriteLine("You Lose");
            }
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
            Console.WriteLine("Ok, i got Pizza, Burger and Soup. Which one do you want to eat?");
            string whatFood = Console.ReadLine();
              if(whatFood == "Pizza"){
                Console.WriteLine("YEAH, pizza good choice!");
              }
              else if(whatFood == "Burger"){
          Console.WriteLine("ooooooooh, good choice");
        }
              else{
                Console.WriteLine("Ok soup it is");
              }
        }
        else{
            Console.WriteLine("Bruh");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
}


Console.ReadLine();
