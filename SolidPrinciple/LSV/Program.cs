using LSV;

class Program
{
    static void Main(string[] args)
    {
        Bird sparrow = new Sparrow();
        Bird penguin = new Penguin();

        sparrow.Move(); 
        penguin.Move();  
    }
}
