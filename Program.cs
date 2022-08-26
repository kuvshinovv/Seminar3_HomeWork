
// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

/* void Function(int a){
    if (a == 1) Console.WriteLine("Значение х>0 y>0");
    else if (a == 2) Console.WriteLine("Значение х<0 y>0"); 
    else if (a == 3) Console.WriteLine("Значение х<0 y<0"); 
    else if (a == 4) Console.WriteLine("Значение х>0 y<0");    
    else Console.WriteLine("Ввод не соответствует условиям");
}

Console.WriteLine("Введите номер четверти (1-4): ");
int num = Convert.ToInt32(Console.ReadLine());
Function(num);
 */



// Вторая задача.

/* void Function(int x, int y){
    if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
    else if (x<0 && y>0) Console.WriteLine("Вторая четверть"); 
    else if (x<0 && y<0) Console.WriteLine("Третья четверть"); 
    else if (x>0 && y<0) Console.WriteLine("Четвертая четверть");   
    
}
Console.WriteLine("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x==0 || y == 0) Console.WriteLine("Не соответствует условиям задачи");
Function(x,y);


 */

// Третья задача
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void Func(int n){
    int count = 1;
    while (count <= n ) {
        Console.Write(count*count + ", ");
        count++;
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0) Console.WriteLine("Не корректное число!");

Func(num);



// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве

//???




