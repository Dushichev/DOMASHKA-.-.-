/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).*/
Console.WriteLine("введите число");
int A = int.Parse(Console.ReadLine());

if(A%2 ==0)
{
    Console.WriteLine("число является четным и делится на 2 без остатка");

}

else if(A%2 != 0)
{
     Console.WriteLine("число не  является четным");
}