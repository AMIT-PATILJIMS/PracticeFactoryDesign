namespace PracticeFactoryDesign
{
    enum MyCarChoice
    {
        Tata,
        Tesla
    }

    public class MyCar
    {
        public virtual void Car() { }
    }

    public class Tata : MyCar
    {
        public override void Car()
        {
            Console.WriteLine("It's my Neno car");
        }
    }

    public class Tesla : MyCar
    {
        public override void Car()
        {
            Console.WriteLine("It's my tesla");
        }
    }

    public static class CarFactory
    {
        public static MyCar GetMyCar(int choice)
        {
            if (choice == (int)MyCarChoice.Tata)
            {
                return new Tata();
            }
            else
            {
                return new Tesla();
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = CarFactory.GetMyCar(1);

            myCar.Car();
        }
    }
}
