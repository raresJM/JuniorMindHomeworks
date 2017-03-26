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
            CollectionAssert.AreEqual(result, Operation(2,"AND",2));
        }
        [TestMethod]
        public void BaseTwoTest_AND_2_4()
        {
            byte[] result = { 0 };
            CollectionAssert.AreEqual(result, Operation(2, "AND", 4));
        }
        [TestMethod]
        public void BaseTwoTest_AND_2_0()
        {
            byte[] result = { 0 };
            CollectionAssert.AreEqual(result, Operation(2, "AND", 0));
        }
        [TestMethod]
        public void BaseTwoTest_OR_2_2()
        {
            byte[] result = { 1, 0 };
            CollectionAssert.AreEqual(result, Operation(2, "OR", 2));
        }
        [TestMethod]
        public void BaseTwoTest_OR_2_3()
        {
            byte[] result = { 1, 1 };
            CollectionAssert.AreEqual(result, Operation(2, "OR", 3));
        }
        [TestMethod]
        public void BaseTwoTest_OR_2_0()
        {
            byte[] result = { 1, 0 };
            CollectionAssert.AreEqual(result, Operation(2, "OR", 0));
        }
        [TestMethod]
        public void BaseTwoTest_XOR_2_3()
        {
            byte[] result = { 1 };
            CollectionAssert.AreEqual(result, Operation(2, "XOR", 3));
        }
        [TestMethod]
        public void BaseTwoTest_XOR_2_2()
        {
            byte[] result = { 0 };
            CollectionAssert.AreEqual(result, Operation(2, "XOR", 2));
        }
        [TestMethod]
        public void BaseTwoTest_Left_2_1()
        {
            byte[] result = { 1, 0, 0 };
            CollectionAssert.AreEqual(result, Shift(2, "<<", 1));
        }
        [TestMethod]
        public void BaseTwoTest_Left_4_1()
        {
            byte[] result = { 1, 0, 0, 0 };
            CollectionAssert.AreEqual(result, Shift(4, "<<", 1));
        }
        [TestMethod]
        public void BaseTwoTest_Right_4_1()
        {
            byte[] result = { 1, 0 };
            CollectionAssert.AreEqual(result, Shift(4, ">>", 1));
        }
        [TestMethod]
        public void BaseTwoTest_Right_4_4()
        {
            byte[] result = { 0 };
            CollectionAssert.AreEqual(result, Shift(4, ">>", 4));
        }


        public List<byte> Shift(int number, String operation, int bitsToShift)
        {
            List<byte> result = new List<byte>();
            List<byte> numberAsBinary = DecimalToBaseTwo(number);
            if (operation.Equals("<<"))
            {
                for (int i = 0; i < bitsToShift; i++)
                {
                    numberAsBinary.Add(0);
                }
                
            }
            else if (operation.Equals(">>"))
            {
                int counter = bitsToShift;
                while (counter > 0)
                {
                    int tail = numberAsBinary.Count-1;
                    numberAsBinary.RemoveAt(tail);
                    counter--;
                }
            }

            result = numberAsBinary;
            return result;
        }


        private List<byte> Operation(int number1, String operation, int number2)
        {
            int nr1 = 0;
            int nr2 = 0;
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
                nr1 = AddZeroIfCase(number1BinaryReversed, i);
                nr2 = AddZeroIfCase(number2BinaryReversed, i);

                byte valueToInsert =
                    (
                    BinaryExpression(nr1, operation, nr2)
                    ) ? (byte)1 : (byte)0;
                result.Insert(i, valueToInsert);
            }
            result.Reverse();
            RemoveLeadingZeroes(result);
            return result;
        }

        private int AddZeroIfCase(List<byte> numberBinaryReversed, int i)
        {
            int nr;
            if (i >= numberBinaryReversed.Count)
            {
                nr = 0;
            }
            else
            {
                nr = numberBinaryReversed[i];
            }

            return nr;
        }

        private void RemoveLeadingZeroes(List<byte> result)
        {
            int i = 0;
            while (result.Count>1)
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

        private Boolean BinaryExpression(int number1, String op, int number2)
        {
            Boolean result = false;
            switch (op)
            {
                case "XOR":
                    result = 
                        (1 == number1 || 1 == number2)
                        &&
                        (!(1 == number1 && 1 == number2));break;
                case "OR":
                    result =
                        (1 == number1 || 1 == number2); break;
                case "AND":
                    result =
                        (1 == number1 && 1 == number2); break;
                default: break;
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
