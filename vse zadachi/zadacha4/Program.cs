// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("введите число C");
int C = int.Parse(Console.ReadLine());

if(A > B && A>C)
{
    Console.Write("больше число ");
    Console.WriteLine(A);
}
    
else if(A < B && B>C)
{
    Console.Write("Больше число ");
    Console.WriteLine(B);
}
else if(C>A && B<C)
{
    Console.Write("Больше число ");
    Console.WriteLine(C);
}