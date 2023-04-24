namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Payments pagamento = new Payments();


        }
    }

    public class Payments
    {
        private DateTime Vencimento;

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