
// нахождение большего из трех чисел 
Console.WriteLine("введите число a=");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("введите число b=");
 int b = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("введите число c=");
 int c = Convert.ToInt32(Console.ReadLine());
 
 if (a>b)
{
    if (a>c)
    {
    Console.WriteLine("max="); 
    System.Console.WriteLine(a);
    }
    else
    {
   Console.WriteLine("max="); 
   System.Console.WriteLine(c);   
}
}
else
if (b>c)
    {
    Console.WriteLine("max="); 
    System.Console.WriteLine(b);
    }
else  
{
   Console.WriteLine("max="); 
   System.Console.WriteLine(c);
}