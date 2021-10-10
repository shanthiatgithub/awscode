using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AWSCODE_CLI;

namespace AWSCODE_unitTEST
{
    [TestFixture]
    public class AROperClass
    {
        [TestCase]
        public void Add()
        {
            OperationClass OR_obj = new OperationClass();
            int result = OR_obj.Addition(20, 10);
            Assert.AreEqual(30, result);
        }
        [TestCase]
        public void Subtract()
        {
            OperationClass OR_obj = new OperationClass();
            int result = OR_obj.Subtraction(20, 10);
            Assert.AreEqual(10, result);
        }
        [TestCase]
        public void Multiply()
        {
            OperationClass OR_obj = new OperationClass();
            int result = OR_obj.Multiplication(20, 10);
            Assert.AreEqual(200, result);
        }
        [TestCase]
        public void Divide()
        {
            OperationClass OR_obj = new OperationClass();
            int result = OR_obj.Division(20, 5);
            Assert.AreEqual(4, result);
        }
        [TestCase]
        public void Mod()
        {
            OperationClass OR_obj = new OperationClass();
            int result = OR_obj.Modulus(28,3);
            Assert.AreEqual(1, result);
        }
    }
}
