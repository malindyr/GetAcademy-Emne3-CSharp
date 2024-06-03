public class Slay
{
    public int a { get; set; }
    public int b { get; set; }

    public void slays()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
    }

    public int AddSlay(int a, int b)
    {
        return a + b;
    }
}