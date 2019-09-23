using System;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            string content = "<book genre='novel' ISBN='1-861001-57-5'>" +
                        "<title>Pride And Prejudice</title>" +
                        "</book>";
            Console.WriteLine(content);
            Console.WriteLine();

            //Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(content);

            //Create a deep clone.  The cloned node 
            //includes the child node.
            XmlDocument deep = (XmlDocument)doc.CloneNode(true);
            Console.WriteLine(deep.Name);
            Console.WriteLine(deep.OuterXml);
            Console.WriteLine(deep.ChildNodes.Count);
            Console.WriteLine();

            //Create a shallow clone.  The cloned node does not 
            //include the child node.
            XmlDocument shallow = (XmlDocument)doc.CloneNode(false);
            Console.WriteLine(shallow.Name);
            Console.WriteLine(shallow.OuterXml);
            Console.WriteLine(shallow.ChildNodes.Count);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
