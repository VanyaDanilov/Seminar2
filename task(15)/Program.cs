Console.WriteLine("Введите число дня недели, где Понедельник = 1, Вторник = 2 и т.д ");
int num = int.Parse(Console.ReadLine());
if(num % 7 == 0 || num % 6 == 0 ){
    Console.WriteLine("Выходной");
}
else{
    Console.WriteLine("Не выходной");
}