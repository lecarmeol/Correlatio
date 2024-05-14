using RICPFitter.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhysicsPlotter.Models
{
    public class FunctionCollection
    {
        public List<IFittable> FittableFunctions { get; set; } = [];

        public List<IGenerable> GenerableFunctions { get; set; } = [];

        public FunctionCollection()
        {
            
        }

        public void SetSelectedFitFunction(string name)
        {
            selectedFitFuncIdx = FittableFunctions.FindIndex(f => f.Name == name);
            if (selectedFitFuncIdx == -1) throw new Exception($"Function {name} not found in the fittable function list");
        }
        private int selectedFitFuncIdx = 0;

        public IFittable GetSelectedFitFunction()
        {
            return FittableFunctions[selectedFitFuncIdx];
        }

        public void SetSelectedGenerableFunction(string name)
        {
            selectedGenFuncIdx = GenerableFunctions.FindIndex(f => f.Name == name);
            if (selectedGenFuncIdx == -1) throw new Exception($"Function {name} not found in the generable function list");
        }
        private int selectedGenFuncIdx = 0;

        public IGenerable GetSelectedGenerableFunction()
        {
            return GenerableFunctions[selectedGenFuncIdx];
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
                    result.FittableFunctions.Add(ExternalFunc.FromXml(node));
                    result.GenerableFunctions.Add(ExternalFunc.FromXml(node));
                }
            }
            return result;
        }
    }
}
