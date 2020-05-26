using System;

namespace Interfaces
{
    public interface INotifications
    {
        /*An interface defines what is needed, it's as if an 
        interface defines the what and the classes that inherits 
        it define the how*/
        // Members
        void showNotification();
        string getDate();
    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        //Default Constructor
        public Notification()
        {
            sender = "Admin";
            message = "Yo, what's up?";
            date = " ";
        }
        public Notification(string mySender, string myMessage, string MyDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.date = MyDate;
        }
        // As the interface is public, the members used from it have to be public too
        public void showNotification()
        {
            Console.WriteLine("Message {0} - was sent by {1} - at {2}", message, sender, date);
        }
        public string getDate()
        {
            return date;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notification nx = new Notification();
            Notification n1 = new Notification("Daniel", "Yo, how you doin?", "25.06.2020");
            Notification n2 = new Notification("Jesús", "We vibin bro, what bout u", "25.06.2020");
            n1.showNotification();
            n2.showNotification();
            nx.showNotification();
        }
    }
}
