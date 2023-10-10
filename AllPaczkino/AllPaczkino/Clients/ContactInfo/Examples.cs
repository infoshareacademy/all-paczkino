namespace AllPaczkino.Clients.ContactInfo
{
    internal static class Examples
    {
        public static readonly List<ContactData> DataCollection = new List<ContactData>
        {
            new ("Zuzia", "Frydrych", "zuzia.frydrych@op.pl", "601888635", new Adress("Katowicka", 87, "Poznan", "Wlkp", "62-131", null, 10)),
            new ("Kuba", "Nowak", "kuba.nowak@op.pl", "897395173", new Adress("Polska", 2, "Poznan", "Wlkp", "60-221", null)),
            new ("Ola", "Wilska", "ola.wilska@op.pl", "607382175", new Adress("Marciniaka", 7, "Poznan", "Wlkp", "60-462", null, 7)),
        }
    }
}
