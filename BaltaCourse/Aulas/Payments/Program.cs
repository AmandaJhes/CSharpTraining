namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Payments pagamento = new Payments();

            Console.WriteLine(pagamento.MyVar);


        }
    }

    public class Payments
    {
        DateTime Vencimento;

        public int Property { get; set; }
        private int _MyVar;

        public int MyVar
        {
            get { return _MyVar; }
            set { _MyVar = value; }
        }

        public int My { get; private set; }


        public void Pay()
        {

        }

        protected void ConsultarDadodDoCartao()
        {

        }
    }

    public class PaymentsBoleto : Payments
    {
        void Teste()
        {
            base.ConsultarDadodDoCartao();
        }
    }
}