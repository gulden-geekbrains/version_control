//4.	Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
//а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.Read());

for (int count = 2; count <= number; count += 2)
{
    Console.Write($"{count} ");
}