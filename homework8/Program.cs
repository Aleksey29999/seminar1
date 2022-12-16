// показывает все четные  от 1 до N

Console.WriteLine("введите число");
 int Number = Convert.ToInt32(Console.ReadLine());
int Number1 = 1;
while (Number1 <= Number)
{if  (Number1 % 2 != 0)
{
 Number1++; 
  }
  else
{
System.Console.WriteLine(Number1);    
Number1++;
}
 }
