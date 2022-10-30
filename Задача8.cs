//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("введите целое число чтобы вывести все чётные числа от него до 1");
int num = Convert.ToInt32(Console.ReadLine());
while(num>2){
    if (num%2==0){
            Console.WriteLine(num + ", ");
    }
    num--;
}
if (num==2)
{
    Console.WriteLine(num);
}
else{Console.WriteLine("нет подходящих чисел");}