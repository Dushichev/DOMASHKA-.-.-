/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.*/
Console.WriteLine("введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int B = int.Parse(Console.ReadLine());
if(A > B)
{
    Console.Write("больше число ");
    Console.WriteLine(A);
}
    
if(A < B)
{
    Console.Write("Больше число ");
    Console.WriteLine(B);
}
