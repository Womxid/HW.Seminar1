//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите по очереди два числа, чтобы определить большее");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.WriteLine($"Большее число {num1}");
}
    else if(num1 < num2) {Console.WriteLine($"Большее число {num2}");
    }
    
    else if(num1 == num2) {Console.WriteLine("Вы ввели одно число дважды");
    }