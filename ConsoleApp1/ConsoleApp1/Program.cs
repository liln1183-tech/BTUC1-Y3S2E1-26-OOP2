
int x = 11;

System.Console.WriteLine($"X at first is {x}");
displayParam(x);
System.Console.WriteLine($"X after is {x}");


static void displayParam(int x)
{
    x = 99;
    System.Console.WriteLine($"X in the method is : {x}");

}