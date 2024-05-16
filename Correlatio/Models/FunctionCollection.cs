using Correlatio.Models;
using RICPFitter.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhysicsPlotter.Models
{
    public class FunctionCollection : IFunctionCollection
    {
        public List<IFittable> Functions { get; set; } = [];

        public FunctionCollection()
        {
            
        }

        public FunctionCollection(List<IFittable> listOfFunctions) : this()
        {
            Functions = listOfFunctions;
        }

        public IFittable FindByName(string name, string category = null)
        {
            if (category != null)
            {
                return Functions.Find(func => func.Name == name &&  func.Category == category);
            }
            else
            {
                return Functions.Find(func => func.Name == name);
            }
        }

        public static FunctionCollection FromXML(string xmlFilePath)
        {
            FunctionCollection result = new();

            XmlDocument xmlDoc = new();
            xmlDoc.Load(xmlFilePath);
            if (xmlDoc.DocumentElement.Name != "Functions") throw new Exception($"File {xmlFilePath} is not a relevant configuration file");
            foreach(XmlNode node in xmlDoc.DocumentElement.ChildNodes)
            {
                if (node.Name == "Function")
                {
                    result.Functions.Add(ExternalFunc.FromXml(node));
                }
            }
            return result;
        }

        public object Clone()
        {
            IFunctionCollection result = new FunctionCollection(new List<IFittable>(Functions));
            return result;
        }
    }
}
