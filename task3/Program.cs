// Написать программу, которая задаёт массив из 8 элементов и выводит их на экран
//взяла диапазон от 0 до 100
int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.WriteLine(array[i]);
}