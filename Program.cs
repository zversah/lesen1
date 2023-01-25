Console.Clear();
int a=new Random().Next(100,1000);
Console.WriteLine(a);
a = (a / 10) % 10;
Console.WriteLine($"Вторая цифра числа => {a}");