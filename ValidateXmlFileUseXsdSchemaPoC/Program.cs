using System;
using System.IO;
using System.Text;
using ValidateXmlFileUseXsdSchemaPoC.Interfaces;
using ValidateXmlFileUseXsdSchemaPoC.Services;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    internal static class Program
    {




        static void Main(string[] args)
        {
            string FileDirectory = @"TEST\";
            string[] fileXml = Directory.GetFiles(FileDirectory);

            var xsd = File.ReadAllText(@"Assets\Schemat_JPK_VAT(3)_v1-1.xsd");

            IXmlFileValidation saxon = new SaxonValidate(xsd);
            IXmlFileValidation xmlValidate = new XmlDocumentValidate(xsd);

            foreach (string file in fileXml)
            {
                var xml = File.ReadAllText(file, Encoding.UTF8);
                Console.WriteLine($"saxon- {file} => {saxon.Validate(xml)}");
                Console.WriteLine($"{file} => {xmlValidate.Validate(xml)}");
            }
            Console.ReadKey();
        }
    }
}
