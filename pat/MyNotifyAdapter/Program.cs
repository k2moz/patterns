using System;

namespace MyNotifyDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Notify notify1 = new UserNotify();
            notify1 = new EmailNotify(notify1);
            notify1.SendNotify();


            Notify notify2 = new AdminNotify();
            notify2 = new EmailNotify(notify2);
            notify2 = new SignalRNotify(notify2);
            notify2.SendNotify();

            Console.ReadLine();
        }
    }

    #region Entity
    public abstract class Notify
    {
        public abstract void SendNotify();
    }

    public class UserNotify : Notify
    {
        public override void SendNotify()
        {
            Console.WriteLine();
            Console.WriteLine("Notify was sended to User");
        }
    }
    public class AdminNotify : Notify
    {
        public override void SendNotify()
        {
            Console.WriteLine();
            Console.WriteLine("Notify was sended to Admin");
        }
    }
    #endregion


    #region Decorators
    public abstract class NotifyDecorator : Notify
    {
        protected Notify Notify;
        public NotifyDecorator(Notify notify) {
            this.Notify = notify;
        }
    }

    public class EmailNotify : NotifyDecorator
    {
        public EmailNotify(Notify notify):base(notify)
        {

        }

        public override void SendNotify()
        {
            Notify.SendNotify();
            Console.WriteLine("by Email");
        }
    }

    public class SignalRNotify : NotifyDecorator
    {
        public SignalRNotify(Notify notify) : base(notify)
        {

        }

        public override void SendNotify()
        {
            Notify.SendNotify();
            Console.WriteLine("by Socket");
        }
    }
    #endregion

}
