namespace dz1
{
    public class Calc
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; } 
        private char action;

        public char Action
        {
            get { return action; }
            set {
                if (value == '-' || value == '+' || value == '/' || value == '*')
                    action = value;
                else
                    throw new Exception("Impossible Action");
            }
        }

        public Calc()
        {
            this.FirstNumber = 0;
            this.SecondNumber = 0;
        }
        public double GetResult()
        {
            switch (this.Action)
            {
                case '+':
                     return this.FirstNumber + this.SecondNumber;
                case '-':
                    return this.FirstNumber - this.SecondNumber;
                case '*':
                    return this.FirstNumber * this.SecondNumber;
                case '/':
                    return this.FirstNumber / this.SecondNumber;
                default:
                    throw new Exception("no action assigned");
            }
        }

    }
    internal class Program
    {
        static void Main()
        {
            Calc calc = new Calc();
            int firstNum;
            do
            {
                Console.Clear();
                Console.Write("Enter the first nummber: ");
            } while (!int.TryParse(Console.ReadLine(), out firstNum));
            calc.FirstNumber = firstNum;

            int secondNum;
            do
            {
                Console.Clear();
                Console.Write("Enter the second nummber: ");
            } while (!int.TryParse(Console.ReadLine(), out secondNum));
            calc.SecondNumber = secondNum;

            char action;
            while (true)
            {
                do
                {
                    Console.Clear();
                    Console.Write("enter action(+/-/*//): ");
                } while (!char.TryParse(Console.ReadLine(), out action));

                try
                {
                    Console.Clear();
                    calc.Action = action;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
          
                }
            }

            double result = calc.GetResult();
            Console.WriteLine($"{calc.FirstNumber} {calc.Action} {calc.SecondNumber} = {result}");

        }
    }
}