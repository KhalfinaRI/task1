// 2ой способ через ввод значения пользователем: 
// принимает на вход число 
// и проверяет, кратно ли оно 7 && 23

Console.Write("Введите число num: ");
int num = int.Parse(Console.ReadLine());
int cond1 = 7;
int cond2 = 23;

if (num % cond1 == 0 && num % cond2 == 0)
{
    Console.WriteLine($"Число {num} - кратно {cond1} и {cond2}");
}
else{
    Console.WriteLine($"Число {num} не кратно {cond1} и {cond2}");
}
