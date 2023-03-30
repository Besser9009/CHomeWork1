Console.Clear();
Console.Write("Введите число: ");
string num = Console.ReadLine();
double number = Convert.ToInt32(num);
if (number % 2 == 0){
    Console.WriteLine("Yes!");
}
else {
    Console.WriteLine("No...");
}