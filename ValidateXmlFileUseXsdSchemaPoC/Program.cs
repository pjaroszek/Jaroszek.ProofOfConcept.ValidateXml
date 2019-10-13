using System.Text;

namespace ValidateXmlFileUseXsdSchemaPoC
{
    using System;
    using System.IO;

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


            var factory = new ValidateConditioner().ExecuteValidation(Actions.XmlDocument, xsd);
            var factorySaxon = new ValidateConditioner().ExecuteValidation(Actions.Saxon, xsd);

            foreach (string file in fileXml)
            {
                var xml = File.ReadAllText(file, Encoding.UTF8);

                Console.WriteLine($"{file} => {factory.Validate(xml)}");
                Console.WriteLine($"saxon- {file} => {factorySaxon.Validate(xml)}");

            }

            Console.ReadKey();
        }
    }
}
