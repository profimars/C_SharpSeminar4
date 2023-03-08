//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите натуральное число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В");
int B = Convert.ToInt32(Console.ReadLine());
int q = Convert.ToInt32(Math.Pow(A, B));
Console.WriteLine("A в степени B равно " + q);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int GetSum(int k)
{
    int sum = 0;
    while (k > 0)
    {
        int d = k % 10;
        sum = sum + d;
        Console.WriteLine("Текущая цифра в числе = " + d);
        k = k / 10;
    }
    return sum;
}
Console.WriteLine("Введите натуральное число k");
int k = Convert.ToInt32(Console.ReadLine());
int sum = GetSum(k);
Console.WriteLine("Сумма цифр в числе = " + sum);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int[] GetArray()
{
    int size = 8;
    int[] AA = new int[size];
    Random rnd = new Random();
    for (int ii = 0; ii < size; ii++)
    {
        int zz = rnd.Next(0, 100);
        AA[ii] = zz;
    }
    return AA;
}
int[] AAA = GetArray();
int iii = 0;
while (iii < AAA.Length)
{
    int ddd = AAA[iii];
    Console.Write(ddd + ", ");
    iii++;
}