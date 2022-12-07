Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (9999 < N && N < 100000)
{
    int a = N / 10000;
    int b = N / 1000 % 10;
    int c = N / 10 % 10;
    int d = N % 10;
    if (a == d && b == c)
    {
        Console.WriteLine("Число " + N + " является палиндромом");
    }
    else
    {
        Console.WriteLine("Число " + N + " не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено неверное число");
}
