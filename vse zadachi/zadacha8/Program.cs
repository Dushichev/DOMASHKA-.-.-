/* Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.
*/
Console.WriteLine("введите число A равное 1");
int A  = int.Parse(Console.ReadLine());
Console.WriteLine("введите число N");
int N  = int.Parse(Console.ReadLine());

for(int i = A;i<=N;i++)
{    
    if(i%2==0)
    Console.WriteLine(i);
}
