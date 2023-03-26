
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
Задача No12. Работа в группах
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно
123
*/ 

Random random = new Random();
int randomValue = random.Next(100, 1000);

int firstTwoDigits = randomValue / 100; 

int secondDigit = randomValue % 10;

Console.WriteLine($"{randomValue} -> {firstTwoDigits}{secondDigit}"); 









