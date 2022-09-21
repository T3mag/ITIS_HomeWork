//Шахматы(Конь)

int NumberA, NumberB;
char A, B;

//Первая координата
A = char.Parse(Console.ReadLine());
NumberA = int.Parse(Console.ReadLine());

//Вторая координата
B = char.Parse(Console.ReadLine());
NumberB = int.Parse(Console.ReadLine());

//Код программы
if (NumberA >= 1 && NumberA <= 8 && NumberB >= 1 && NumberB <= 8)
{
    if ((Math.Abs(NumberB - NumberA) + 1 == 2 && Math.Abs(B - A) + 1 == 3) || (Math.Abs(NumberB - NumberA) + 1 == 3 && Math.Abs(B - A) + 1 == 2))
    {
        Console.WriteLine("Конь ходить может!");
    }
    else
    {
        Console.WriteLine("Конь ходить не может!");
    }
}
else
{
    Console.WriteLine("Не коректные даннные! Измените входные данные!");
}