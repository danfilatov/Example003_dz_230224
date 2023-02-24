//Task 6; Программа, которая на вход принимает 1 число и выдает, является ли число четным
Console.WriteLine("Task 6; Программа, которая на вход принимает 1 число и выдает, является ли число четным");
Console.Write("Введите ваше число: "); 
int numA = Convert.ToInt32 (Console.ReadLine());

if (numA %2==0)
{
     Console.WriteLine($"Число: {numA} является четным");
}
else
{
     Console.WriteLine($"Число: {numA} является нечетным");
}