using net_calculator_tester;
using Newtonsoft.Json;
using NUnit.Framework.Constraints;

namespace Tests
{

    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test(Description = "Addizione tra due numeri")]
        [TestCase(2.2f, 1.1f, (2.2f + 1.1f))]
        [TestCase(2.0f, -1.1f, 0.9f)]
        [TestCase(0, 0, 0)]
        [TestCase(float.MaxValue, 100, float.MaxValue + 100)]
        public void TestAddizione(float num1, float num2, float risultato)
        {
            Assert.That(Calculator.Addizione(num1, num2), Is.EqualTo(risultato));
        }

        //---------------------------------------\\

        [Test(Description = "Sottrazione tra 2 numeri")]
        [TestCase(2.2f, 1.1f, (2.2f - 1.1f))]
        [TestCase(2.0f, -1.1f, (2.0f - (-1.1f)))]
        [TestCase(0, 0, 0)]
        public void TestSottrazione(float num1, float num2, float risultato)
        {

            Assert.That(Calculator.Sottrazione(num1, num2), Is.EqualTo(risultato));
        }

        //---------------------------------------\\

        [Test(Description = "Divisione tra un float e lo zero")]
        [TestCase(5)]
        public void TestDivisioneConZero(float num1)
        {
            Assert.Throws<ArgumentException>(() => Calculator.Divisione(num1, 0));
        }

        //---------------------------------------\\

        [Test(Description = "Divisione tra due numeri")]
        [TestCase(2.2f, 1.1f, (2.2f / 1.1f))]
        [TestCase(2.0f, -1.1f, (2.0f / -1.1f))]

        public void TestDivisione(float num1, float num2, float risultato)
        {
            Assert.That(Calculator.Divisione(num1, num2), Is.EqualTo(risultato));
        }


        //---------------------------------------\\

        [Test(Description = "Moltiplicazione tra due numeri")]
        [TestCase(2.2f, 1.1f, (2.2f * 1.1f))]
        [TestCase(2.0f, -1.1f, (2.0f * -1.1f))]
        [TestCase(5, 0, 0)]
        public void TestMoltiplicazione(float num1, float num2, float risultato)
        {

            Assert.That(Calculator.Moltiplicazione(num1, num2), Is.EqualTo(risultato));
        }
    }

}