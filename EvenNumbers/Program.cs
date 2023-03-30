Console.Clear();
Console.Write("Введите максимальное колличество чисел: ");
string MaxNum = Console.ReadLine();
int N = Convert.ToInt32(MaxNum);
int number = 1;
while (number < N + 1){
    if (number % 2 == 0){
        Console.WriteLine(number);
    }
    number += 1;
}
