#region 
//The "#region" can be used to 'collapse' areas of code so you can focus on the key areas
//Comments can be done in a couple different ways, after // and multiline between /* comment */
/*
multi
line
comment
*/

//All of these functionalities is for the programmers, the compiler deletes them when creating the executable (.exe)
//Programmers can use them to document their code and help future programmers understand their thinking.
#endregion

#region Assignment; Write your own story
/* Todays assignment
*   Run this program
*   Read and understand this programs source code
*   Write a short story using the Console for input and output
*   Try to make use of as many of the below techniques as possible
*/

//Console.WriteLine("...");
//Console.ReadLine();
//int.Parse("123");
//if, elseif, else

//bool ExampleBool = true;
//int ExampleInt = 123;
//float ExampleFloat = 123.21f;
//string ExampleString = "Example 123";
#endregion

#region Variables
Console.WriteLine("What is your favorite food?");

//<Type> <Name> = <Value> ;
string myString = "This is how to define a string variable!";

//Reading a string from the console
myString = Console.ReadLine();

//Writing it back to the console
Console.WriteLine("Aaah " + myString + " thats a good choice, nice to meet you!");
Console.WriteLine("My favorite food is Burger with fires");
#endregion

#region Data types
string StringInputFromConsole;
Console.WriteLine("Do you want to play Among us?");

StringInputFromConsole = Console.ReadLine();

bool BooleanInput = false;
if(StringInputFromConsole == "yes" || StringInputFromConsole == "no")
{
  BooleanInput = true;
}

if(BooleanInput == true)
{
  Console.WriteLine("This is going to be epic!"); 
}
else
{
  Console.WriteLine("Oh ok do you want to play a boardgame?"); 
}

Console.ReadLine();
#endregion


/* Teachers corner

* Operators; +, -, /, *, %, ++, --, *=, +=, -=

* Casting
int.Parse()
Convert.ToInt32()
(int)
*/