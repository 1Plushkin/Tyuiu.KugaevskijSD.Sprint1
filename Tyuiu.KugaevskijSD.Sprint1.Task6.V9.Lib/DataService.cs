namespace Tyuiu.KugaevskijSD.Sprint1.Task6.V9.Lib;
    public class DataService : Sprint1Task6V9
{
    public string MoveLetterToStart(string value)
    {
        string result = "";
        foreach (string s in value.Split(" "))
        {
            List<char> xx = new List<char>((s[s.Length - 1] + s).ToCharArray());
            xx.RemoveAt(s.Length);
            result += new string(xx.ToArray()) + " ";
        }
        List<char> x = new List<char>(result.ToCharArray());
        x.RemoveAt(result.Length - 1);
        return new string(x.ToArray());
    }
}