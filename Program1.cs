    Console.Write("Введите четверть:");
    int xx = Convert.ToInt32(Console.ReadLine());
    string check_xy (int x)
    {
     if (x==1) return "первая четверть: x>0 y>0";
     else if (x==4)
     {
        return("четвертая четверть: x>0 y<0");
     }
     else if (x==3) return "третья четверть: x<0 y<0";
     else if (x==2) return "вторая четверть: x<0 y>0";
     else return "нет такой четверти";
    }
    Console.WriteLine (check_xy(xx));

    /*Console.Write("Введите четверть:");
    int xx = Convert.ToInt32(Console.ReadLine());
    void check_xy (int x)
    {
     if (x==1) Console.WriteLine("первая четверть: x>0 y>0");
     else if (x==4)
     {
        Console.WriteLine("четвертая четверть: x>0 y<0");
     }
     else if (x==3) Console.WriteLine("третья четверть: x<0 y<0");
     else if (x==2) Console.WriteLine("вторая четверть: x<0 y>0");
     else Console.WriteLine("нет такой четверти");
    }
    check_xy(xx);*/

    /*Console.Write("Введите четверть:");
    int x = Convert.ToInt32(Console.ReadLine()); 
    if (x==1) Console.WriteLine("первая четверть: x>0 y>0");
    else if (x==4)
    {
    Console.WriteLine("четвертая четверть: x>0 y<0");
    }
    else if (x==3) Console.WriteLine("третья четверть: x<0 y<0");
    else if (x==2) Console.WriteLine("вторая четверть: x<0 y>0");
    else Console.WriteLine("нет такой четверти");*/
    
    