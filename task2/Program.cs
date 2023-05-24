// Написать программу, которая принимает на вход число и выдаёт сумму всех цифр в числе

int N = Convert.ToInt32(Console.ReadLine());

int Sum(int N)
{
    int nach = Convert.ToString(N).Length;
    int start = 0;
    int result = 0;

    for (int i = 0; i < nach; i++)
    {
        start = N - N%10;
        result = result + (N - start);
        N = N / 10;
    }
    return result;
}

int summa = Sum(N);
Console.WriteLine("Сумма цифр равна: " + summa);