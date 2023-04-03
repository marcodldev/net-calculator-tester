using net_calculator_tester;

namespace Tests
{


    [TestFixture]
    public class Tests
    {

        private float num1;
        private float num2;
        private float risultato;

        [SetUp]
        public void Setup()
        {
            num1 = 7.5f;
            num2 = 3.5f;
           
        }

        [Test(Description = "Addizione tra i due numeri costanti espressi sopra")]
        public void TestAddizione()
        {
            
            float operazione = Calculator.Addizione(num1, num2);
            float risultato = 11;

            Assert.That(operazione, Is.EqualTo(risultato));
        }

        [Test(Description = "Sottrazione tra i due numeri costanti espressi sopra")]
        public void TestSottrazione()
        {

            float operazione = Calculator.Sottrazione(num1, num2);
            float risultato = 4;

            Assert.That(operazione, Is.EqualTo(risultato));
        }
        
        [Test(Description = "Divisione (arrotondata) tra i due numeri costanti espressi sopra")]
        public void TestDivisione()
        {

            float operazione = Calculator.Divisione(num1, num2);
            float risultato = 2.14f;

            Assert.That(operazione, Is.EqualTo(risultato));
        }

        [Test(Description = "Moltiplicazione tra i due numeri costanti espressi sopra")]
        public void TestMoltiplicazione()
        {

            float operazione = Calculator.Moltiplicazione(num1, num2);
            float risultato = 26.25f;

            Assert.That(operazione, Is.EqualTo(risultato));
        } 
    }
}