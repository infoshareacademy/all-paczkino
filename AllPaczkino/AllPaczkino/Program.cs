using Parcels.Parcels;
using AllPaczkino.Models;
using AllPaczkino.Repositories;
using Newtonsoft.Json;
using AllPaczkino.View;
using AllPaczkino.Clients.ContactInfo;

namespace AllPaczkino
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // wyswietlenie menu poczatkowego - login
            LoginMenu loginMenu = new LoginMenu();
            loginMenu.ShowLoginMenu();

           
        }
    }
}
