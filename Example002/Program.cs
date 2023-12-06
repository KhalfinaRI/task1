// Принмает на вход координаты точки (Х, У), причем Х != 0 и У != 0
// и выдает номер координатной плоскости (четверти), где точка.

Console.WriteLine("Введите координаты точки по оси x, отличные от 0: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки по оси y, отличные от 0: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в четверти №1");
}
else if(x>0 && y <0)
{
    Console.WriteLine("Точка находится в четверти №4");
}
else if(x<0 && y <0)
    {
        Console.WriteLine("Точка находится в четверти №3");
    }
else if(x<0 && y >0)   
{
    Console.WriteLine("Точка находится в четверти №2");
} 
else 
{
    Console.WriteLine("Неверно указаны координаты точки, одно из значений = 0");
}
