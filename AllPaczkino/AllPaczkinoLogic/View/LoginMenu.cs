namespace AllPaczkino.View
{
    public class LoginMenu
    {
        ConsoleKeyInfo key;
        
        public void ShowLoginMenu()
        {
			Console.WriteLine("Welcome to AllPaczkino!");
			Console.WriteLine("LOGIN MAIN MENU:\n");
    		Console.WriteLine("Press A to login as admin");
			Console.WriteLine("Press B to login as client");
			
            //to na przyszłość
            /*
            Console.WriteLine("Press C to register new user.");
            Console.WriteLine("Press D to reset password.");
            */

            Console.WriteLine("Press Esc to quit");
            do
            {
                key = Console.ReadKey(intercept: true);
                switch (key.Key)
                {
					case ConsoleKey.A:
						{
							Console.WriteLine("\nLogged in as admin\n");
							
                            AdminMenu adminMenu = new AdminMenu();
                            adminMenu.ShowAdminMenu();  

							break;
						};

					case ConsoleKey.B:
						{
							Console.WriteLine("\nLogged in as client\n");

                            ClientMenu clientMenu = new ClientMenu();
                            clientMenu.ShowClientMenu();

							break;
						};
/*
					case ConsoleKey.C:
                        {
                            Console.WriteLine("Write login and press enter: ");
                            Console.WriteLine("Write password and press enter: ");
                            break;
                        };

                    case ConsoleKey.D:
                        {
                            Console.WriteLine(" To be implemented ....");
                            break;
                        };
                    case ConsoleKey.E:
                        {
                            Console.WriteLine(" To be implemented ....");
                            break;
                        };
*/

                    case ConsoleKey.Escape: break;
                }

            } while (key.Key != ConsoleKey.Escape);
        }
    }
    
}
