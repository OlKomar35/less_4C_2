// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberPrint(string msg){
    Console.Write($"Введите {msg} =");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int SumOfNum(int num){
    int sum = 0;
    num = Math.Abs(num);
    while(num > 0){
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int number = NumberPrint("num");
Console.WriteLine($"Сумма цифр числа {number} равна {SumOfNum(number)}");