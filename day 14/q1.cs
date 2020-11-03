using System;
using System.Threading.Tasks;
using Accountlibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
namespace day14
{
    
    class q1
    {
        static void SaveAsSoapFormat(object objGraph, string fileName)  //Serialisation
        {
            // Save object to a file named CarData.soap in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved employee in SOAP format!");
        }
        static void LoadFromFile(string fn)
        {

            // read object to a file named CarData.soap in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fn, FileMode.Open))
            {
                Account[] obj = (Account[])soapFormat.Deserialize(fStream);

                foreach (Account e in obj)
                    Console.WriteLine("{0}  {1}", e.Name, e.Balanceamt);
            }

        }

        static void Main()
        {
            Account[] a = new Account[2];
            a[0] = new Account("shweta", 20000);
            a[1] = new Account("abc", 22000);

            SaveAsSoapFormat(a, "account.soap");
           string fn = "account.soap";
            LoadFromFile(fn);

        }

    }
}
