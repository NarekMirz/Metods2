// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cube(int x)
{
    for (int i = 1 ; i <=x; i ++)
    {
        Console.Write(i*i*i + " ");
    }
    
}
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
cube(x);
