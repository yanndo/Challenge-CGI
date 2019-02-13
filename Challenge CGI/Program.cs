namespace Challenge1
{

    class Program
    {
        static void Main(string[] args)
        {
            
            var methods = new Menu();
            methods.FirstMethod = "1";
            methods.SecondMethod = "2";
            methods.ThirdMethod = "3";
            methods.Leave = "Leave";
            methods.Choice();

            var method1 = new Method1();
            method1.One();
            var method2 = new Method2();
            method2.Two();
            var method3 = new Method3();
            method3.Three();
            var leave = new Leave();
            leave.Four();

        }
    }
}
