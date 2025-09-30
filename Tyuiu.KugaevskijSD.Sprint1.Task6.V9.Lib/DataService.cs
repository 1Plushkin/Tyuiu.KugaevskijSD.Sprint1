using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KugaevskijSD.Sprint1.Task6.V9.Lib;
    public class DataService : ISprint1Task6V9
{
    public string MoveLetterToStart(string value)
    {
        string temp = "";

        string[] li = value.Split(' ');
        foreach (string t in li)
        {
            string ans = "";
            ans += t[t.Length - 1];
            for (int i = 0; i < t.Length - 1; i++)
            {
                ans += t[i];
            }
            temp += ' ' + ans;
        }
        return temp.Trim();
    }
}