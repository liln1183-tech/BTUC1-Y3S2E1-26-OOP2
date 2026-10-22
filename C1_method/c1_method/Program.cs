

using System.Security.Cryptography.X509Certificates;
using c1_method;

// Console.WriteLine("Hello, World!");

// class1.staticMethod();

// class1 Obj1 = new class1();
// Obj1.someMethod(); 

int a = 10;
System.Console.WriteLine($"a (before) = {a}");
fun1(a);
System.Console.WriteLine($"a (after) = {a}");


int[] arr ={3, 11, 22, 33} ;
for (int i=0; i<arr.Length; i++)
    {
        System.Console.Write($" {arr[i]}");
    }
System.Console.WriteLine();
fun2_array(arr);
System.Console.WriteLine();
for (int i=0; i<arr.Length; i++){
        System.Console.Write($" {arr[i]}");
}


// pass by value   : -> two different items 
static void fun1(int a)
{
   a = 99; 
   System.Console.WriteLine($"a (in method) = {a}");    
}


// pass by reference :   ->  two labels   -> same items 
static void fun2_array(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = 99;
        System.Console.Write($" {arr[i]}");
    }
}

// in 
// static void displayInParam(in int x)
// {
//     // x is pass as read-only
//     // x = 99;   
//     int z = 100*x;
//     //x = 33;

//     System.Console.WriteLine($"X in the method is : {x}");
// }

static void displayInParam(int x, int z,  int y=0, int w = 1)
{

    System.Console.WriteLine($"X in the method is : {x}");
    System.Console.WriteLine($"Y in the method is : {y}");
    System.Console.WriteLine($"Z in the method is : {z}");
    System.Console.WriteLine($"W in the method is : {w}");
}

displayInParam(2,3,4,5);   // positional argument 
displayInParam(w:6, x:5, y:4, z:3); // named argument 