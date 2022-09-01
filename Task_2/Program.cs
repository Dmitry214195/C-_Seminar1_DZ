// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

 Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
 {
    Console.WriteLine("Первое число, " + number_1 + " больше, чем второе " + number_2);
}
else if (number_1 < number_2)
{
    Console.WriteLine("Второе число " + number_2 + " больше, чем первое " + number_1);
}
else
{
    Console.WriteLine("Числа равны ");
}