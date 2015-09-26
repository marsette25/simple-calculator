using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    public class CommandPrompt
    {
        [TestMethod]
        public void CommandPromptValueFirst()
        {
            CommandPrompt myPrompt = CommandPrompt("0");
            Assert.AreEqual("x", response.Value);
        }

        //[TestMethod]
        //public void NodeDefaultNext()
        //{
        //    SinglyLinkedListNode node = new SinglyLinkedListNode("foo");
        //    Assert.IsNull(node.Next);
        //}

        //[TestMethod]
        //public void NodeSetNext()
        //{
        //    SinglyLinkedListNode node1 = new SinglyLinkedListNode("foo");
        //    SinglyLinkedListNode node2 = new SinglyLinkedListNode("bar");
        //    node1.Next = node2;
        //    Assert.AreEqual(node2, node1.Next);
        //    Assert.IsNull(node2.Next);
        }
    }
