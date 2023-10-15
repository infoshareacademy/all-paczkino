namespace AllPaczkino.View
{
    public class LoginPage
    {
        ConsoleKeyInfo key;
        
        public void ShowLogin()
        {
            Console.WriteLine("###########################################");
            Console.WriteLine("Press 'L to login.");
            Console.WriteLine("Press 'A' to register new user.");
            Console.WriteLine("Press 'R' to reset password.");
            Console.WriteLine("Press 'Spacebar' to quit.");
            do
            {
                key = Console.ReadKey(intercept: true);
                switch (key.Key)
                {
                    case ConsoleKey.L:
                        {
                            Console.WriteLine("Write login and press enter: ");
                            Console.WriteLine("Write password and press enter: ");
                            break;
                        };

                    case ConsoleKey.A:
                        {
                            Console.WriteLine(" To be implemented ....");
                            break;
                        };
                    case ConsoleKey.R:
                        {
                            Console.WriteLine(" To be implemented ....");
                            break;
                        };

                    case ConsoleKey.Spacebar: break;
                }

            } while (key.Key != ConsoleKey.Spacebar);
        }
    }
    
}
