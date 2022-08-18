/*Console.Write("Введите номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
string chetvert (int a)
{
    if (a == 1) return "Для первой четверти x > 0; y > 0";
    else if (a == 2) return "Для второй четверти x < 0; y > 0";
    else if (a == 3) return "Для третьей четверти x < 0; y < 0";
    else if (a == 4) return "Для четвёртой четверти x > 0; y < 0";
    else return "введены некорректные данные";
}

Console.WriteLine(chetvert(a));*/


/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

/*задача 3* - на входе функции натуральное число N, и потом формируется массив из N членов ряда Фибоначчи*/

//задача1//
/*Console.Write("Введите кооординату x первой точки: ");
double a_x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату y первой точки: ");
double a_y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату x второй точки: ");
double b_x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату y второй точки: ");
double b_y = Convert.ToDouble(Console.ReadLine());
double points (double a_x, double a_y, double b_x, double b_y)
{
    double num = (b_x - a_x) * (b_x - a_x) + (b_y - a_y) * (b_y - a_y);
    return Math.Sqrt(num);
}

Console.WriteLine(points(a_x, a_y, b_x, b_y));*/

//задача2//
/*Console.Write("введите число:");
int xx = Convert.ToInt32(Console.ReadLine());
void program (int a) 
{
    for (int i=1; i<=a; i++)
    {
        Console.Write(i*i+" ");
    }  
      
}

program (xx);*/

//задача 3

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    
}

int[] array=new int[N];
array[0]=0;
array[1]=1;
int index = 2;
while(index<N)
{
    array[index] = array[index -1]+array[index-2];
    index++;
}

PrintArray(array);

