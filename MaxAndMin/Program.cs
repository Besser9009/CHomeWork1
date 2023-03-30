Console.Clear();
Console.Write("Введите первое число: ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
Console.Write("Введите второе число: ");
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);
if (number1 > number2){
    Console.Write("min = ");
    Console.WriteLine(number2);
    Console.Write("max = ");
    Console.WriteLine(number1);
}
else{
    Console.Write("min = ");
    Console.WriteLine(number1);
    Console.Write("max = ");
    Console.WriteLine(number2);
}
