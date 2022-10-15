using System.Runtime.Serialization;

namespace Serizlization_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Fish a = new Fish();
            a.food = "meat";
            a.name = "A_Fish";
            a.gender = "male";

            Fish b = new Fish();
            b.food = "vegt";
            b.name = "B_Fish";
            b.gender = "female";


            Console.WriteLine(a);
            Console.WriteLine(b);

            using (FileStream fs = new FileStream("TESTFile.xml", FileMode.OpenOrCreate)) { 
            
                DataContractSerializer dcs = new DataContractSerializer(typeof(Fish));
                dcs.WriteObject(fs, a);
            
            }


            using (FileStream fs = new FileStream("TESTFile.xml", FileMode.Open))
            {

                DataContractSerializer dcs = new DataContractSerializer(typeof(Fish));
                Fish c = dcs.ReadObject(fs) as Fish;
                Console.WriteLine("fish c:{0}", c);

            }

        }
    }
}