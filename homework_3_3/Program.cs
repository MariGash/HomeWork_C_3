void FillArray(int[] collection)
{
    for (int i = 1; i <= collection.Length; i = i+1)
    {
        Console.WriteLine("{0}\t{1}", i, i*i*i);
    }
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число\tКуб");

int[] array = new int[N];
FillArray(array);
