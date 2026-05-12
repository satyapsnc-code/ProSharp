namespace ProgramesCsharp
{
    public class BankBalalance
    {

        private double _depositeAmount;

        public double DepositeAmount
        {
            get { return _depositeAmount + 200; }
            set
            {
                if (value > 0)
                {
                    _depositeAmount = value;
                    Console.WriteLine("deposited amount is :-  " + value);

                }
                else
                {
                    Console.WriteLine("please enter valed amount, amount must be more then ZERO  " + value);
                }
            }
        }


    }
    abstract class AbstactData
    {
        public abstract void pay();
        public virtual void display( string name )
        {
            Console.WriteLine("name of candidate parent "+name);
        }
    }
     internal class Somthing : AbstactData
     {
        public override void pay()
        {
            Console.WriteLine("this is abstact");
        }
        public override void display(string name)
        {
            Console.WriteLine("name of candidate child " + name);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankBalalance bankBalalance = new BankBalalance();
            //bankBalalance.DepositeAmount = 19;
            //Console.WriteLine("deposited amount is :-  " + bankBalalance.DepositeAmount);

            Somthing somthing = new Somthing();
            somthing.pay();
            somthing.display("satya PSNC");
        }
    }
}
