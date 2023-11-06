Console.WriteLine("введите n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите x:");
double x = double.Parse(Console.ReadLine());
switch (n) 
{
    case 1:
        {
            double a = 0.1;
            double b = 0.5;
            double z = Math.Exp(2.5 * a * x);
            double y;
            if (x <= a) y = (3.5 * Math.Pow(Math.Sin(b * x + z), 2) * Math.Pow(Math.Sin(b * x + z), 3));
            else if (a < x && x <= Math.Pow(b, 2.5)) y = Math.Log(a) + Math.Log(Math.Pow(b, 3)) * Math.Log(x);
            else if (x > Math.Pow(b, 2.5)) y = Math.Pow(Math.Cos(Math.Pow(a, b) + x * z), 2) + Math.Pow(a, 2);
            

        } break;
    case 2:
        {
            double a = 1.2;
            double b = 2.5;
            double z = Math.Exp(2.5 * a * x);
            double y;
            if (x <= a) y = (3.5 * Math.Pow(Math.Sin(b * x + z), 2) * Math.Pow(Math.Sin(b * x + z), 3));
            else if (a < x && x <= Math.Pow(b, 2.5)) y = Math.Log(a) + Math.Log(Math.Pow(b, 3)) * Math.Log(x);
            else if (x > Math.Pow(b, 2.5)) y = Math.Pow(Math.Cos(Math.Pow(a, b) + x * z), 2) + Math.Pow(a, 2);
            
        } break;
    case 3:
        {
            double a = 2.5;
            double b = 1.2;
            double z = Math.Exp(2.5 * a * x);
            double y;
            if (x <= a) y = (3.5 * Math.Pow(Math.Sin(b * x + z), 2) * Math.Pow(Math.Sin(b * x + z), 3));
            else if (a < x && x <= Math.Pow(b, 2.5)) y = Math.Log(a) + Math.Log(Math.Pow(b, 3)) * Math.Log(x);
            else if (x > Math.Pow(b, 2.5)) y = Math.Pow(Math.Cos(Math.Pow(a, b) + x * z), 2) + Math.Pow(a, 2);
            
        }break;
        


}
