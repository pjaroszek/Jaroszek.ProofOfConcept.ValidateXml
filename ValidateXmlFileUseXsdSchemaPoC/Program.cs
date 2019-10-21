using ValidateXmlFileUseXsdSchemaPoC.Interfaces;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    using System;
    using System.IO;
    using System.Text;
    using ValidateXmlFileUseXsdSchemaPoC.Services;

    internal static class Program
    {
        private const string DEFAULT_DATA_DIRECTORY = "XmlFileToTest";


        internal static void Main(string[] args)
        {
            string[] fileXml = Directory.GetFiles(DEFAULT_DATA_DIRECTORY);
            string xsd = File.ReadAllText(@"Assets\Schemat_JPK_VAT(3)_v1-1.xsd");

            //            var saxon = new XmlDocumentValidateUseSaxon(xsd);
            //            var xmlValidate = new XmlDocumentValidate(xsd);
            //
            //            foreach (string file in fileXml)
            //            {
            //                var xml = File.ReadAllText(file, Encoding.UTF8);
            //                Console.WriteLine($"saxon- {file} => {saxon.Validate(xml)}");
            //                Console.WriteLine($"{file} => {xmlValidate.Validate(xml)}");
            //            }


            IXmlFileValidation aa = new XmlDocumentValidate(xsd);
            IXmlFileValidation bb = new XmlDocumentValidateUseSaxon(xsd);
            foreach (string file in fileXml)
            {
                var xml = File.ReadAllText(file, Encoding.UTF8);
                Console.WriteLine($"saxon- {file} => {bb.Validate(xml)}");
                Console.WriteLine($"{file} => {aa.Validate(xml)}");
            }



            Console.ReadKey();
        }
    }
}
