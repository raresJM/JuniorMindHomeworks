using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BaseTwo
{
    [TestClass]
    public class BaseTwo
    {
        [TestMethod]
        public void BaseTwoTest_2_10()
        {
            byte[] result = {1,0};
            CollectionAssert.AreEqual(result, DecimalToBaseTwo(2));
        }
        [TestMethod]
        public void BaseTwoTest_3_11()
        {
            byte[] result = {1,1};
            CollectionAssert.AreEqual(result, DecimalToBaseTwo(3));
        }
        [TestMethod]
        public void BaseTwoTest_NOT_2()
        {
            byte[] result = {0, 1};
            CollectionAssert.AreEqual(result, Not(2));
        }
        [TestMethod]
        public void BaseTwoTest_NOT_0()
        {
            byte[] result = {1};
            CollectionAssert.AreEqual(result, Not(0));
        }
        [TestMethod]
        public void BaseTwoTest_AND_2_2()
        {
            byte[] result = {1, 0};
            CollectionAssert.AreEqual(result, BinaryOperations(2,"AND",2));
        }
        [TestMethod]
        public void BaseTwoTest_AND_2_4()
        {
            byte[] result = { 0 };
            CollectionAssert.AreEqual(result, BinaryOperations(2, "AND", 4));
        }
        [TestMethod]
        public void BaseTwoTest_AND_2_0()
        {
            byte[] result = { 0 };
            CollectionAssert.AreEqual(result, BinaryOperations(2, "AND", 0));
        }
        [TestMethod]
        public void BaseTwoTest_OR_2_2()
        {
            byte[] result = { 1, 0 };
            CollectionAssert.AreEqual(result, BinaryOperations(2, "OR", 2));
        }
        [TestMethod]
        public void BaseTwoTest_OR_2_3()
        {
            byte[] result = { 1, 1 };
            CollectionAssert.AreEqual(result, BinaryOperations(2, "OR", 3));
        }
        [TestMethod]
        public void BaseTwoTest_OR_2_0()
        {
            byte[] result = { 1, 0 };
            CollectionAssert.AreEqual(result, BinaryOperations(2, "OR", 0));
        }
        [TestMethod]
        public void BaseTwoTest_XOR_2_3()
        {
            byte[] result = { 1 };
            CollectionAssert.AreEqual(result, BinaryOperations(2, "XOR", 3));
        }
        [TestMethod]
        public void BaseTwoTest_XOR_2_2()
        {
            byte[] result = { 0 };
            CollectionAssert.AreEqual(result, BinaryOperations(2, "XOR", 2));
        }

        public List<byte> BinaryOperations(int number1, String op, int number2)
        {
            List<byte> result = new List<byte>();
            List<byte> number1AsBinary = DecimalToBaseTwo(number1);
            List<byte> number2AsBinary = DecimalToBaseTwo(number2);
            switch (op)
            {
                case "XOR": result = XOr(number1,number2);break;
                case "OR": result = Or(number1AsBinary, number2AsBinary);break;
                case "AND": result = And(number1AsBinary, number2AsBinary);break;
                default: break;
            }
            return result;
        }

        private List<byte> XOr(int number1, int number2)
        {
            List<byte> result = new List<byte>();
            List<byte> number1BinaryReversed = DecimalToBaseTwo(number1);
            number1BinaryReversed.Reverse();
            List<byte> number2BinaryReversed = DecimalToBaseTwo(number2);
            number2BinaryReversed.Reverse();

            int maxLength = Math.Max
                (
                number1BinaryReversed.Count, 
                number2BinaryReversed.Count
                );

            for (int i = 0; i < maxLength; i++)
            {
                byte valueToInsert =
                    (
                    (1 == number1BinaryReversed[i] || 1 == number2BinaryReversed[i])
                    &&
                    (!(1 == number1BinaryReversed[i] && 1 == number2BinaryReversed[i]))
                    ) ? (byte)1 : (byte)0;
                result.Insert(i, valueToInsert);
            }
            result.Reverse();
            RemoveLeadingZeroes(result);            
            return result;
        }

        private void RemoveLeadingZeroes(List<byte> result)
        {
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i] == 0)
                {
                    result.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }
        }

        private List<byte> Or(List<byte> number1AsBinary, List<byte> number2AsBinary)
        {
            List<byte> result = new List<byte>();
            EqualizeLengthWithFrontZeroes(number1AsBinary, number2AsBinary);
            int length = number1AsBinary.Count;
            for (int i = 0; i < length; i++)
            {
                byte valueToInsert = (1 == number1AsBinary[i] || 1 == number2AsBinary[i]) ? (byte)1 : (byte)0;
                result.Insert(i, valueToInsert); 
            }
            return result;
        }

        private void EqualizeLengthWithFrontZeroes(List<byte> number1AsBinary, List<byte> number2AsBinary)
        {
            if (number1AsBinary.Count > number2AsBinary.Count)
            {
                for (int i = 0; i < number1AsBinary.Count - number2AsBinary.Count; i++)
                {
                    number2AsBinary.Insert(i, 0);
                }
            }
            else if (number2AsBinary.Count > number1AsBinary.Count)
            {
                for (int i = 0; i < number2AsBinary.Count - number1AsBinary.Count; i++)
                {
                    number1AsBinary.Insert(i, 0);
                }
            }
        }

        private List<byte> And(List<byte> number1AsBinary, List<byte> number2AsBinary)
        {
            List<byte> result = new List<byte>();
            int length = number1AsBinary.Count;
            if (number1AsBinary.Count != number2AsBinary.Count)
            {
                result.Add(0);
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    byte valueToInsert = (1 == number1AsBinary[i] && 1 == number2AsBinary[i]) ? (byte)1 : (byte)0;
                    result.Insert(i, valueToInsert);
                }
            }
            return result;
        }

        private List<byte> Not(int number)
        {
            List<byte> result = new List<byte>();
            result = DecimalToBaseTwo(number);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            return result;
        }

        private List<byte> DecimalToBaseTwo(int number)
        {
            List<byte> result = new List<byte>();
            if (number == 0)
            {
                result.Add(0);
            }else
            {
                while (number > 0)
                {
                    result.Insert(0, (byte)(number % 2));
                    number = number / 2;
                }
            }
            return result;  
        }
    }
}
