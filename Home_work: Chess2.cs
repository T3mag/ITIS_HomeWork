//Шахматы(Ладья)

int NumberA, NumberB;
char A, B;

//Первая координата!
A = char.Parse(Console.ReadLine());
NumberA = int.Parse(Console.ReadLine());

//Вторая координата!
B = char.Parse(Console.ReadLine());
NumberB = int.Parse(Console.ReadLine());

//Код программы
if (NumberA >= 1 && NumberA <= 8 && NumberB >= 1 && NumberB <= 8)
{
    if ((A == B && NumberA != NumberB) || (NumberA == NumberB && A != B))
    {
        Console.WriteLine("Ладья может ходить!");
    }
    else
    {
        Console.WriteLine("Ладья не может ходить!");
    }
}
else
{
    Console.WriteLine("Не коректные данные!");
}
