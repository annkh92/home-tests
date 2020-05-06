using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace H_7
{
    public class Tests
    {

        [Test]
        public void Test1()
        {

            Calculator.Methods n = new Calculator.Methods();

            var x = Enumerable.Range(0, 20); //заменяется на (2, 20);
            var y = Enumerable.Range(0, 20); //заменяется на (5, 20);

            foreach ( int a in x)
            {
                foreach (int b in y)
                {
                    double result = n.addition(a, b);
                    Assert.AreEqual(a + b, result, "{0} + {1} = {2}", a, b, result);
                    
                }
            }

        }

        [Test]
        public void Test2()
        {

            Calculator.Methods n = new Calculator.Methods();

            var x = Enumerable.Range(0, 20); //заменяется на (9, 20);
            var y = Enumerable.Range(0, 20); //заменяется на (11, 20);

            foreach (int a in x)
            {
                foreach (int b in y)
                {
                    double result = n.difference(a, b);
                    Assert.AreEqual(a - b, result, "{0} - {1} = {2}", a, b, result);

                }
            }

        }

        [Test]
        public void Test3()
        {

            Calculator.Methods n = new Calculator.Methods();

            var x = Enumerable.Range(0, 20); //заменяется на (20, 20);
            var y = Enumerable.Range(1, 20); //заменяется на (12, 20);

            foreach (int a in x)
            {
                foreach (int b in y)
                {
                    double result = n.division(a, b);
                    int r = (int)result;
                    Assert.AreEqual(a / b, r, "{0} / {1} = {2}", a, b, r);

                }
            }

        }

        [Test]
        public void Test4()
        {

            Calculator.Methods n = new Calculator.Methods();

            var x = Enumerable.Range(0, 20); //заменяется на (16, 20);
            var y = Enumerable.Range(0, 20); //заменяется на (14, 20);

            foreach (int a in x)
            {
                foreach (int b in y)
                {
                    double result = n.multiplication(a, b);
                    Assert.AreEqual(a * b, result, "{0} * {1} = {2}", a, b, result);

                }
            }

        }
    }
}