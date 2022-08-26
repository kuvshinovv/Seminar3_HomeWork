
/* Задача 19___________________________________________________________________________________________
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/* 
void Func(int n){
    int first = n / 10000;       //Находим первую цифру в ведённом числе
        Console.WriteLine("Первое число - " + first);
    
    int secondtmp = n / 1000;
    int second = secondtmp % 10;  //Находим вторую цифру в ведённом числе
        Console.WriteLine("Второе число - " + second);

    int forthtmp = n / 10;
    int forth = forthtmp % 10;    //Находим четвёртую цифру в ведённом числе
        Console.WriteLine("Четвертое число - " + forth);
     
    int fifth = n % 10;           //Находим пятую цифру в ведённом числе
    Console.WriteLine("Пятое число - " + fifth);
    
    if (first == fifth && second == forth){   // Сравниваем (первое и пятое) число &&  (второе и четвёртое) число.
        Console.Write("Введённое число ЯВЛЯЕТСЯ ПАЛИНДРОМОМ! - " + n);
    }
    else{
        Console.Write("Введённое число НЕ является палиндромом!");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 9999 && num < 100000){    //  Проверяем чтобы введеное число было пятизначным...
    Func(num);
}
else{
    Console.WriteLine("Введённое число НЕ пятизначное и не подходит по условию задачи!");
}
 */








/* Задача 21 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

 //d = √((хА –  хВ)2 + (уА – уВ)2 + (zА – zВ)2)
/* 
double d;   // Искомое расстояние между точками

// вводим координаты вдух точек по трем координатам x, y ,z
Console.WriteLine("Введите координату Х точки А: ");  
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Х точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());
 
 // Вычисляем по формуле расстояние, расчет и вывод на экран производим в самой функции
void Function(double xA, double yA, double zA, double xB, double yB, double zB){
            d = Math.Sqrt(((xA-xB)*(xA-xB)) + ((yA-yB)*(yA-yB)) + ((zA-zB)*(zA-zB)));
    Console.WriteLine("Расстояние между точками A("+ xA +" , "+ yA +" , "+ zA +") и B("+ xB +" , "+ yB +" , "+ zB+") = "+ d);
}
// Вызываем функцию (метод) для ее испорлнения
Function(xA, yA, zA, xB, yB, zB);
  */









/* Задача 23__________________________________________________________________________________
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


/* void Func(int n){
    int count = 1;
    while (count <= n ) {
        Console.Write(count*count*count + ", ");
        count++;
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 0) Console.WriteLine("Не корректное число!");
Func(num);
 */










