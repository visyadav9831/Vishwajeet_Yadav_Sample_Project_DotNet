public delegate int SampleDelegate();
public class Program
{
    public static int Method1()
    {
        return 1;
    }
    public static int Method2()
    {
        return 2;
    }
    static void Main(string[] args)
    {
        SampleDelegate sampleDelegate = new SampleDelegate(Program.Method1);
        sampleDelegate += Program.Method2;
        int returnDelegateType = sampleDelegate();
        Console.WriteLine(returnDelegateType);
    }
}