/* //Задача 2
Console.WriteLine("Введи первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (number1 < number2)
{
    Console.WriteLine("П3ервое число больше второго");
}
else
{
    Console.WriteLine("Оба числа равны");
}
Console.ReadKey();
 */
//Задача 4
int a = 1;
int b = 2;
int c = 3;
int max, min, mid;

if (a > b && a > c)
{
    max = a;
    min = (b < c) ? b : c;
}
else if (b > a && b > c)
{
    max = b;
    min = (a < c) ? a : c;
}
else
{
    max = c;
    min = (b < a) ? a : b;
}

//Задача 6
int g;
Console.Write("Введите число");
g= Console.Read();

if (g % 2==1)
{
    Console.WriteLine("Число нечетное");
}
else
{
    Console.WriteLine("Число четное");
}

Console.Read();

//Задача 8
Console.Write("Введите одно число");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <=n; i++)
if (i % 2== 0);
Console.WriteLine(i);