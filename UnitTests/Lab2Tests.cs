using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //Lab2 Tests
        #region
        [TestMethod]
        public void Parentheses1()
        {
            Assert.IsTrue(Lab2.Program.IsBalanced("{()}{}"));
        }

        [TestMethod]
        public void Parentheses2()
        {
            Assert.IsTrue(Lab2.Program.IsBalanced("{ int a = new int[ ] ( ( ) ) }"));
        }

        [TestMethod]
        public void Parentheses3()
        {
            
            Assert.IsFalse(Lab2.Program.IsBalanced("{ [ ] ) ) ( ( "));
        }

        //this one has the right number of corresponding braces but in the wrong order
        [TestMethod]
        public void Parentheses4()
        {
            Assert.IsFalse(Lab2.Program.IsBalanced("{[}]"));
        }

        [TestMethod]
        public void Parentheses5()
        {
            Assert.IsFalse(Lab2.Program.IsBalanced("{"));
        }

        [TestMethod]
        public void Parentheses6()
        {
            
            Assert.IsFalse(Lab2.Program.IsBalanced("("));
        }

        [TestMethod]
        public void Parentheses7()
        {
            
            Assert.IsFalse(Lab2.Program.IsBalanced("["));
        }

        [TestMethod]
        public void Parentheses8()
        {
            
            Assert.IsFalse(Lab2.Program.IsBalanced("}"));
        }

        [TestMethod]
        public void Parentheses9()
        {
            
            Assert.IsFalse(Lab2.Program.IsBalanced(")"));
        }

        [TestMethod]
        public void Parentheses10()
        {
            
            Assert.IsFalse(Lab2.Program.IsBalanced("]"));
        }

        [TestMethod]
        public void Parentheses11()
        {
            string testString = "namespace UnitTestProject1 {[TestClass] public class UnitTest1 {[TestMethod] public void OneInt() { DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(); doublyLinkedList.Append(0); Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TwoInt() { DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(); doublyLinkedList.Append(0); doublyLinkedList.Append(0); Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void ThreeInt() { DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(); doublyLinkedList.Append(0); doublyLinkedList.Append(1); doublyLinkedList.Append(0); Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void ManyInt() { DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(); for (int i = -15; i < 16; i++) { doublyLinkedList.Append(Math.Abs(i)); } Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TwoIntF() { DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(); doublyLinkedList.Append(0); doublyLinkedList.Append(1); Assert.IsFalse(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void ThreeIntF() { DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(); doublyLinkedList.Append(3); doublyLinkedList.Append(1); doublyLinkedList.Append(0); Assert.IsFalse(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void ManyIntF() { DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>(); for (int i = 0; i < 16; i++) { doublyLinkedList.Append(Math.Abs(i)); } Assert.IsFalse(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestString1() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); doublyLinkedList.Append(alex); Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestString2() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); doublyLinkedList.Append(alex); doublyLinkedList.Append(alex); Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestString3() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); doublyLinkedList.Append(alex); doublyLinkedList.Append(inner); doublyLinkedList.Append(alex); Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestString4() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); for (int i = 2; i < 51; i++) { if (i % 2 == 0) { doublyLinkedList.Append(one); } else { doublyLinkedList.Append(two); } } Assert.IsTrue(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestStringUseEqualsF1() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); doublyLinkedList.Append(Alex); doublyLinkedList.Append(inner); doublyLinkedList.Append(alex); Assert.IsFalse(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestStringF2() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); doublyLinkedList.Append(Alex); doublyLinkedList.Append(inner); doublyLinkedList.Append(tanner); Assert.IsFalse(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestStringF3() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); doublyLinkedList.Append(inner); doublyLinkedList.Append(alex); Assert.IsFalse(Program.IsPalindrome(doublyLinkedList)); }[TestMethod] public void TestStringF4() { DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>(); for (int i = 3; i < 51; i++) { if (i % 3 == 0) { doublyLinkedList.Append(one); } else { doublyLinkedList.Append(two); } } doublyLinkedList.Append(three); Assert.IsFalse(Program.IsPalindrome(doublyLinkedList)); } } }";
            Assert.IsFalse(Lab2.Program.IsBalanced(testString));
        }

        [TestMethod]
        public void Parentheses12()
        {
            string testString = "List<int> list = new List<int>();";
            Assert.IsTrue(Lab2.Program.IsBalanced(testString));
        }

        [TestMethod]
        public void Parentheses13()
        {
            string testString = "List<int> list = new List<int();";
            Assert.IsFalse(Lab2.Program.IsBalanced(testString));
        }

        [TestMethod]
        public void Parentheses14()
        {
            string testString = "List<int> list = new List int>();";
            Assert.IsFalse(Lab2.Program.IsBalanced(testString));
        }

        [TestMethod]
        public void Parentheses1withNoBrace()
        {
            
            Assert.IsTrue(Lab2.Program.IsBalanced("1"));
        }

        [TestMethod]
        public void ParenthesesWithNoBraces()
        {
            
            Assert.IsTrue(Lab2.Program.IsBalanced("When in the course of Human Events..."));
        }
        #endregion

        //Postfix Tests
        #region
        [TestMethod]
        public void Postfix1()
        {
            
            Assert.AreEqual(4, Lab2.Program.Evaluate("2 2 +"));
        }

        [TestMethod]
        public void Postfix2()
        {
            
            Assert.AreEqual(8, Lab2.Program.Evaluate("5 3 +"));
        }

        [TestMethod]
        public void Postfix3()
        {
            
            Assert.AreEqual(2, Lab2.Program.Evaluate("7 5 -"));
        }

        [TestMethod]
        public void Postfix4()
        {
            
            Assert.AreEqual(1, Lab2.Program.Evaluate("5 3 1 + -"));
        }

        [TestMethod]
        public void Postfix5()
        {
            
            Assert.AreEqual(5, Lab2.Program.Evaluate("15 7 1 1 + - / 3 * 2 1 1 + + -"));
        }

        [TestMethod]
        public void Postfix6()
        {

            Assert.AreEqual(45, Lab2.Program.Evaluate("15 7 1 2 + - / 3 * 2 1 1 + + *"));
        }

        [TestMethod]
        public void Postfix7()
        {

            Assert.AreEqual(-3.4, Lab2.Program.Evaluate("16 15 - 7 1 1 + - / 3 * 2 1 1 + + -"));
        }

        [TestMethod]
        public void Postfix8()
        {

            Assert.AreEqual(1.0/6.0, Lab2.Program.Evaluate("51 32 + 82 - 6 /"));
        }

        [TestMethod]
        public void Postfix9()
        {

            Assert.AreEqual(2030, Lab2.Program.Evaluate("54 62 + 2 / 35 *"));
        }

        [TestMethod]
        public void Postfix10()
        {

            Assert.AreEqual(23, Lab2.Program.Evaluate("10 2 8 * + 3 -"));
        }
        #endregion

    }
}