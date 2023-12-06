// программа на вход принимает натурально число N,
// на выходе показывает его цифры через запятые

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{
    Console.WriteLine(N);
}
else
{
    while (N > 0)
    {
        int first = N % 10;
        N /= 10;
        if (N > 0)
        {
            Console.Write(first + ",");
        }
        else
        {
            Console.Write(first);
        }
    }
}
