namespace DesignPatterns
{
    internal class Program
    {





        static void Main(string[] args)
        {
            SingeltonClass obj=SingeltonClass.GetInstance();

            // this will call the factory and get the instance required.
            ICar factoryObj = new Factory().GetInstance("CarA");
        }
    }
}
