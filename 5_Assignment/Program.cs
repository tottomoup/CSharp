int FibNum = 0, FibNum1 = 1, FibNum2,i;
int Fibman = 35;


Console.WriteLine("do you want to see cool numbers");
Console.ReadLine();
Console.WriteLine("cool");
Console.WriteLine("here cool numbers");
Console.WriteLine("1      " + FibNum );
Thread.Sleep(300);
Console.WriteLine("2      " + FibNum1 );


for (i = 2; i <= Fibman; ++i)
{
   FibNum2 = FibNum1 + FibNum;
   Console.WriteLine(i +":      " + FibNum2);
   Thread.Sleep(300);
   FibNum = FibNum1;
   FibNum1 = FibNum2;
}
Console.ReadLine();