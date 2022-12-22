double InPutNumber(string str) 
{
    Console.WriteLine($"Введите число {str}:"); 
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double xCross = 0;
    double yCross = 0;
    if (b1==b2 & k1==k2)
    {
        System.Console.WriteLine("Прямые совпадают");
    } 
    else if (k1==k2)
    {
         System.Console.WriteLine("Прямые параллельны друг другу");
    }
    else 
    {
        xCross = (b2-b1)/(k1-k2);
        yCross = k1*xCross+b1;
        System.Console.WriteLine("Точка пересечения: ("+ xCross +" ;"+ yCross + ")");
    }
}

double b1 = InPutNumber("b1");
double k1 = InPutNumber("k1");
double b2 = InPutNumber("b2");
double k2 = InPutNumber("k2");
CrossPoint(b1, k1, b2, k2);
