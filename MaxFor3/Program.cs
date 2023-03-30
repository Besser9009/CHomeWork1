Console.Clear();
Console.Write("Введите первое число: ");
string num1 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
Console.Write("Введите второе число: ");
string num2 = Console.ReadLine();
int number2 = Convert.ToInt32(num2);
Console.Write("Введите третье число: ");
string num3 = Console.ReadLine();
int number3 = Convert.ToInt32(num3);
int max = number1;
if (number2 > max){
    max = number2;
}
else if (number3 > max){
    max = number3;
}
Console.Write("max = ");
Console.WriteLine(max);