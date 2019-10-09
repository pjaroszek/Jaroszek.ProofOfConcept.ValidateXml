namespace ValidateXmlFileUseXsdSchemaPoC
{
    using System;
    using System.IO;
    using System.Text;
    using ValidateXmlFileUseXsdSchemaPoC.Services;

    internal static class Program
    {
        internal static void Main(string[] args)
        {
            string fileDirectory = @"XmlFileToTest\";
            string[] fileXml = Directory.GetFiles(fileDirectory);
            var xsd = File.ReadAllText(@"Assets\Schemat_JPK_VAT(3)_v1-1.xsd");

            var saxon = new SaxonValidate(xsd);
            var xmlValidate = new XmlDocumentValidate(xsd);

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
