﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("身長の入力(cm):");
var height = double.Parse(Console.ReadLine()); //身長
Console.Write("体重の入力(kg):");
var weight = double.Parse(Console.ReadLine());  // 体重
                                                //var bmi = weight / ((height / 100) * (height / 100)); // BMIを求める数式
height /= 100;
var bmi = weight / (height * height);  // BMIを算出
Console.Write($"身長={height},体重={weight},\nBMI={bmi.ToString("F2")}");

