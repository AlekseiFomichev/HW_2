﻿// Task 1

string fullName = "Aleksei Fomichev";
string email = "fomichevv@yandex.ru";
double mathResult = 53;
double physicsResult = 49;
double compScienceResult = 50;
int age = 27;

string pattern = "Имя, Фамилия: {0} \nemail: {1} \nбаллы по математике: {2} \nбаллы по физике: {3} \nбаллы по информатике: {4} \nвозраст: {5} лет(год)";
Console.WriteLine(pattern,
                  fullName,
                  email,
                  mathResult,
                  physicsResult,
                  compScienceResult,
                  age);
//Console.ReadKey();


// Task 2

int summResult = (int)mathResult +  (int)physicsResult + (int)compScienceResult;
Console.WriteLine($"Сумма баллов {summResult} ");
double averageValueResult = summResult / 3;
Console.WriteLine($"средний балл { averageValueResult} ");




Console.ReadKey();