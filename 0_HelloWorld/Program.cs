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

if (playgame == "yes")
{
    Console.WriteLine("Nice, do you want to play a videogame?");
    string game = Console.ReadLine();
    if(game == "yes")
    {
        Console.WriteLine("Ok, i got Stick Fight and Minecraft. Which one do you want to play?");
    }
    string whatGame = Console.ReadLine();
    
    if (whatGame == "Stick Fight")
    {

        Console.WriteLine("OkOk Stick Fight it is");
        Console.WriteLine("Type 'Start' to start the game");
        string startGame = Console.ReadLine();
        if (startGame == "Start")
        {

            while (true)
            {

                Console.WriteLine("Type a number between 1-10 to see if you win!");
                int value = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int number = rnd.Next(1, 10);
                if (number == value)
                {
                    Console.WriteLine("You win");
                }
                else
                {
                    Console.WriteLine("You Lose");
                }
                Console.WriteLine("If you want to try again then type 'Play Again', if not then type 'bye'");
                string input = Console.ReadLine();
                if (input == "Play Again")
                    Console.WriteLine("Nice");
                else if (input == "bye")
                    break; // <-- used to get out of a loop
                else
                {
                    Console.WriteLine("sry what?");
                    break;
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Ok, Minecraft it is :)");
        Thread.Sleep(1000);
        Console.WriteLine("Do you want to play Multiplayer");
        string whatMode = Console.ReadLine();
        if (whatMode == "yes")
        {
            Console.WriteLine("Do you want to play on Hypixel");
            string whatServer = Console.ReadLine();
            if (whatServer == "yes")
            {
                Console.WriteLine("Bedwars or Skywars");
                string whatMinecraftGame = Console.ReadLine();
                if (whatMinecraftGame == "Bedwars")
                {
                    Console.WriteLine("Type 'Start' to start the game.");
                    string startMinecraftGame = Console.ReadLine();
                    if (startMinecraftGame == "Start")
                    {


                        while (true)
                        {
                            Console.WriteLine("Type a number between 1-100 to see if you win");
                            int value = Convert.ToInt32(Console.ReadLine());
                            Random rnd = new Random();
                            int number = rnd.Next(1, 100);
                            if (number == value)
                            {
                                Console.WriteLine("You win");
                            }
                            else
                            {
                                Console.WriteLine("You Lose");
                            }
                            Console.WriteLine("If you want to try again then type 'Play Again', if not then type 'bye'");
                            string input = Console.ReadLine();
                            if (input == "Play Again")
                                Console.WriteLine("Nice");
                            else if (input == "bye")
                                break; // <-- used to get out of a loop
                            else
                            {
                                Console.WriteLine("sry what?");
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Skywars ok");
                    Thread.Sleep(1000);
                    Console.WriteLine("Type 'Start' to start the game");
                    string newGame = Console.ReadLine();
                    if (newGame == "Start")
                    {
                        while (true)
                        {
                            Console.WriteLine("Type a number between 1-10 to see if you win");
                            int value = Convert.ToInt32(Console.ReadLine());
                            Random rnd = new Random();
                            int number = rnd.Next(1, 10);
                            if (number == value)
                            {
                                Console.WriteLine("You win");
                            }
                            else
                            {
                                Console.WriteLine("You Lose");
                            }
                            Console.WriteLine("If you want to try again then type 'Play Again', if not then type 'bye'");
                            string input = Console.ReadLine();
                            if (input == "Play Again")
                                Console.WriteLine("Nice");
                            else if (input == "bye")
                                break; // <-- used to get out of a loop
                            else
                            {
                                Console.WriteLine("sry what?");
                                break;
                            }
                        }
                    }
                }
            }
        }

    }
}
else
{
    Console.WriteLine("Do you then want to eat anything?");
   string goodfood = Console.ReadLine();
   if(goodfood == "yes"){ 
    Console.WriteLine("What do you want to eat, Pizza, Burger and Soup");
    string[] favorites = 
     {
        "Pizza",
        "Burger",
        "Soup"
     };
    string food = Console.ReadLine();
    if (food == favorites[0])
    {
     Console.WriteLine("Im going to warm the pizza up, ill be back in 10 min");
     Thread.Sleep(600000);
        Console.WriteLine("Here is your Pizza :)");
    }
    else if(food == favorites[1]){
        Console.WriteLine("Im going to make the food now, ill be back in 30 min");
        Thread.Sleep(2000);
        Console.WriteLine("This is the things im going to put in the burger");
        Thread.Sleep(2000);
            List<string> foodList = new List<string>();

                foodList.Add("Bun");
                foodList.Add("Pickels");
                foodList.Add("Tomato");
                foodList.Add("Salad");
                foodList.Add("Cheese");
                foodList.Add("Steak");
                foodList.Add("Cheese");
                foodList.Add("Bun");

                for (int i = 0; i < foodList.Count; i++)
                {
                    Console.WriteLine(foodList[i]);
                }


        Thread.Sleep(1800000);
        Console.WriteLine("Here is your Burger :)");
    }
    else if(food == favorites[2]){
        Console.WriteLine("Ok im going to make soup now, ill be back in 10 min");
        Thread.Sleep(2000);
        Console.WriteLine("This is the things im going to put in your soup");
        Thread.Sleep(2000);
            List<string> foodList = new List<string>();

                foodList.Add("Water");
                foodList.Add("Carrots");
                foodList.Add("Potatos");
                foodList.Add("Beef");
                foodList.Add("Salt");

                for (int i = 0; i < foodList.Count; i++)
                {
                    Console.WriteLine(foodList[i]);
                }
        Thread.Sleep(600000);
        Console.WriteLine("Here is your soup :)");
        }
   }
}

Console.WriteLine("press enter to exit");
Console.ReadLine();
