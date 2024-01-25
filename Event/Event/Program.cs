namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball();
            Console.WriteLine(ball);
            Player P1 = new Player() { Name = "Messi" , Team="Miami" };
            Player P2 = new Player() { Name = "Martinaze" , Team="Miami" };
            Player P3 = new Player() { Name = "Pedri" , Team="Barca" };
            Player P4 = new Player() { Name = "Gavi" , Team= "Barca" };
            Refree refree = new Refree() {Name="Ibrahim Nour Eldeen"};
            Console.WriteLine("================Before Subscrintion=============");
            //Subscribe
            ball.OnLocationChanged += P1.Running;
            ball.OnLocationChanged += P2.Running;
            ball.OnLocationChanged += P3.Running;
            ball.OnLocationChanged += P4.Running;

            ball.OnLocationChanged += refree.Look;
            Console.WriteLine("================After Subscrintion=============");
            ball.BallLocation = new Location() { X = 10 , Y = 8 , Z = 3};
            Console.WriteLine("================================================");
            ball.BallLocation = new Location() { X = 3, Y = 8, Z = 3 };



        }
    }
}
