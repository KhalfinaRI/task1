// Программа принимает на вход целое число из отрезка [10, 99]
// показывает наибольшую цифру числа

Console.Write("Введите целое число из отрезка [10, 98]: ");
int a = Convert.ToInt32(Console.ReadLine());

int a1 = a / 10;
int a2 = a % 10;

if(a1 > a2)
{
    Console.WriteLine(a1);
}
else if(a1 < a2 )
{
    Console.WriteLine(a2);
}
else 
{
    Console.WriteLine("Числа равны");
}

if (a< 10 || a>98)
{
    Console.WriteLine($"Число {a} выходит за пределы допустимого отрезка");
} 