// Написать цикл, который принимает на вход два числа (А и В) 
// возводит число А в натуральную степень В

int newNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int NewNumber = (int)Math.Pow(a, b);
Console.WriteLine("Итог: " + NewNumber);