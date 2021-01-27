using System;
using System.Collections.Generic;
using Behavioral.Visitor.Components;
using Behavioral.Visitor.Interfaces;
using Behavioral.Visitor.Visitors;

namespace Behavioral.Visitor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var nodes = new List<INode>
            {
                new RootNode(),
                new LeafNode()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var jsonSerializer = new JsonSerializer();
            App.SerializeGraph(nodes, jsonSerializer);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var xmlSerializer = new XmlSerializer();
            App.SerializeGraph(nodes, xmlSerializer);
        }
    }
}