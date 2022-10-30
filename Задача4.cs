Console.WriteLine("Введите по очереди три целых числа чтобы узнать большее из них");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Теперь второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И последнее");
int num3 = Convert.ToInt32(Console.ReadLine());
int maxNum = num1;
if(num2 > num1) maxNum = num2;
if(num3 > num2) maxNum = num3;
{Console.WriteLine($"Большее число {maxNum}");
    }