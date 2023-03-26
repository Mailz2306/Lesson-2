
/* ЗАДАЧА НА ВОПРОСЫ 

int a = 5;

int b = 6;

int c = 7;

int g = 8;

int result1 = Calculate(a,b);
Show(a,b);

int result2 = Calculate(c,g); 
Show(c,g);

Console.WriteLine(result1);
Console.WriteLine(result2);

int Calculate(int a, int b)
{
    return a * (a * b) - 5;
    }

void Show (int a, int b)
{
    Console.WriteLine($"{a} , {b}");
}

НАПИШИТЕ ПРОГРАММУ, КОТОРАЯ ВЫВОДИТ СЛУЧАЙНОЕ ЧИСЛО ОТ 10 ДО 99
И ПОКАЗЫВАЕТ НАИБОЛЬШУЮ ЦИФРУ ЧИСЛА


// рандомно выводит числа от 1 до 3

Random random = new Random();

while(true)
{
    int randomValue = random.Next(1,4);
    Thread.Sleep(100);
    Console.WriteLine(randomValue); 
}

рандомные числа и десятую часть 

Random random = new Random();
int randomValue = random.Next(10, 100);

int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10; 

Console.WriteLine(randomValue);

if(lastDigit > firstDigit){
    Console.WriteLine(lastDigit);
}
else{
    Console.WriteLine(firstDigit);
} 
-------------------
ЗАДАЧА 1:
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98

ЗАДАЧА 2: 
Задача No12. 
Напишите программу, которая будет принимать на вход два числа и выводит, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток
от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно
--------------


Random random = new Random();
int randomValue = random.Next(100, 1000);

int firstTwoDigits = randomValue / 100; 

int secondDigit = randomValue % 10;

Console.WriteLine($"{randomValue} -> {firstTwoDigits}{secondDigit}"); 

------------------- 
РЕШЕНИЕ ВТОРОЙ ЗАДАЧИ 

/*Console.Write("Введите первое число");
int number1 = int.Parse(Cpnsole.ReadLine()); 

Console.Write("Введите второе число");
int number2 = int.Parse(Cpnsole.ReadLine());

int result = number1 % number2; 

if (result == 0)
{
    Console.Write(result);
    Console.Write("кратно");
}
else 
{
    Console.Write(result);
    Console.Write("не кратно");
} 

------------------------ 

Задача No14. Общее обсуждение
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да

Задача No16. Работа в группах
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет 

----------------------------
ЗАДАЧА 14

Console.WriteLine("Введите ваше число и я проверю кратно ли оно 7 и 23");
int a = int.Parse(Console.ReadLine());
if (a % 7 == 0 & a % 23 == 0 ){
    Console.WriteLine($"{a} -> да");
}
else {
    Console.WriteLine($"{a} -> нет");
}
 -----------
 ЗАДАЧА 16 

Console.WriteLine("Введите два числа и я проверю являются ли одно из них квадратом второго");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (b == a * a | a == b * b){
    Console.WriteLine($"{a},{b} -> да является");
}
else {
    Console.WriteLine($"{a},{b} -> нет, не является");
}

КОНЕЦ СЕМИНАРА 

=====================================

ДОМАШНЕЕ ЗАДАНИЕ 26.03.2023 

ЗАДАЧА Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

РЕШЕНИЕ 
Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }
 

-------------------
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

РЕШЕНИЕ ЗАДАЧИ:

int number = ReadInt("Введите трехзначное число и я покажу третью цифру в нём: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("-> Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
---------------------------
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

РЕШЕНИЕ ЗАДАЧИ
*/ 

Console.WriteLine("Введите число и я скажу в неделе это выходной или нет:");
int a = int.Parse(Console.ReadLine());
if (a == 6 | a == 7) 
{
    Console.WriteLine($"{a} -> да");
}
    else if (a <= 5 | a > 7) {
        Console.WriteLine($"{a} -> нет");
    }        
else 
{     
    Console.WriteLine("${a} -> нет");
}    

