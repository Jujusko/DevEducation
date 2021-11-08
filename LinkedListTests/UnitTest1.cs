using NUnit.Framework;
using Nodes;

namespace LinkedListTests
{
    public class Tests
    {
        [TestCase(2, 4)]
       public void AddTest(int a, int addValue)
        {
            Node expected = new Node(a);
            expected.Next = new Node(addValue);
            LinkedList actual = new LinkedList(1);
            actual.AddFront(addValue);
            Assert.AreEqual(actual, expected);
        }   
    }
}