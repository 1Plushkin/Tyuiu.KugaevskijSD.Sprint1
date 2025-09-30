namespace Tyuiu.KugaevskijSD.Sprint1.Task5.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;
public class DataService : ISprint1Task5V7
{
    public int AngleToHoursMinutes(double f)
    {
        if (f >= 0 && f < 360)
        {
            double h = f / 30.0;
            int t = (int)h;
            return t;
        }
        else
        {
            return -1;
        }
    }
}