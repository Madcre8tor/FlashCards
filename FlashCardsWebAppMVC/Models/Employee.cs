namespace FlashCardsWebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //Nicht sicher ob ein Konstruktor richtig ist (im Tutorial wurde keiner verwendet)
        public Employee(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
