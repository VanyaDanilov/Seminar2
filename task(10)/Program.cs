int number = new Random().Next(100,1000);
int num1 = number % 100;
int num2 = num1 / 10;
Console.WriteLine($"Число {num2} из {number}");

