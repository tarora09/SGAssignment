using ISP;

public class Program
{
    static void Main(string[] args)
    {
        Iworkable worker = new Worker();


        worker.Work();
        ((IEatable)worker).Eat();
    }
}