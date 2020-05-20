using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ARGraph;

namespace GraphUnitTesting
{
    [TestClass]
    public class GraphUnitTesting
    {

        [TestMethod]
        
        public void Testing_NodeBased_Constructor()
        {
            // Test CSC382Graph_NodeBased Constructor(s)
            
            //default constructor
            CSC382Graph_NodeBased<int> numbersGraph = new CSC382Graph_NodeBased<int>();

            //verify that the graph is not null and was created successfully as a blank graph
            Assert.IsNotNull(numbersGraph.Graph);

            //therefore the first node of the graph should be null
            Assert.IsNull(numbersGraph.Graph.First);

            //and the length of the graph should be zero
            Assert.AreEqual(0, numbersGraph.Graph.Count);



            // Test creating lots of nodes and edges
            Random ran = new Random();
            int nodeCount = ran.Next(20, 51);

            for (int i = 0; i < nodeCount; i++)
            {
                numbersGraph.Insert(ran.Next());
            }

            
            Assert.AreEqual(nodeCount, numbersGraph.Size());

             //Test functions of the CSC382Graph_NodeBased class and affiliated classes



        }

        [TestMethod]

        public void Testing_NodeBased1()
        {
            // Test CSC382Graph_NodeBased Constructor(s)

            CSC382Graph_NodeBased<string> wordsGraph = new CSC382Graph_NodeBased<string>();

            Assert.IsNull(wordsGraph.Graph.First);
            

            // Test creating lots of nodes and edges
            Random ran = new Random();
            int nodeCount = ran.Next(20, 51);

            for (int i = 0; i < nodeCount; i++)
            {
                wordsGraph.Insert(ran.Next().ToString());
            }

            Assert.AreEqual(nodeCount, wordsGraph.Size());



            // Test functions of the CSC382Graph_NodeBased class and affiliated classes

        }

        [TestMethod]
        public void Testing_NodeBased_Base()
        {
            // Test CSC382Graph_NodeBased Constructor(s)

            // Test functions of the CSC382Graph_NodeBased class

            // Test creating lots of nodes and edges


        }

        [TestMethod]
        public void Testing_AdjacencyList()
        {
            // Test CSC382Graph_AdjacencyList Constructor(s)

            // Test functions of the CSC382Graph_AdjacencyList class

            // Test creating lots of nodes and edges

            
        }
    }
}
