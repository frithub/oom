using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;
using System.IO;



namespace Task4
{
    public interface Icomponent
    {
        void showTurnedOn(bool powerOn); 
        void showDevice();
    }
    public class Switch : Icomponent
    {
        private int power;
        public bool turnedOn;
        public string name;
        private ushort interfaces;
        private UInt32 bandwithMBit;

        public Switch(ushort theInterfaces, UInt32 theBandwithMBit, int watt, bool on, string switchName)
        {

            if (theInterfaces == 0)
                throw new Exception("Keine Interfaces.");
            if (theBandwithMBit == 0)
                throw new Exception("Ungültige Bandbreite.");
            interfaces = theInterfaces;
            bandwithMBit = theBandwithMBit;
            power = watt;
            turnedOn = on;
            name = switchName;
        }


        public void showDevice()
        {
            Console.WriteLine("this is the switch ... " + name); 
        }
        public void showTurnedOn(bool powerOn)
        {
            if (powerOn == true)
                Console.WriteLine("Switched on.");
            else
                Console.WriteLine("Switched off.");
        }
        public ushort Interfaces
        {
            get { return interfaces; }
        }
        public UInt32 BandwithMBit
        {
            get { return bandwithMBit; }
        }
    }



    public class Router : Icomponent
    {
        private int power;
        private bool turnedOn;
        private string name;

        public void showDevice()
        {
            Console.WriteLine("this is the router ...  "); // name?
        }
        public void showTurnedOn(bool powerOn)
        {
            if (powerOn == true)
                Console.WriteLine("Switched on.");
            else
                Console.WriteLine("Switched off.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            Icomponent[] device = new Icomponent[3];
            device[0] = new Switch(24, 1000, 110, false, "Catalyst2960-L");
            device[1] = new Router();
            device[2] = new Switch(24, 1000, 110, false, "Catalyst2960-X");

            for (int i = 0; i < device.Length; i++) // Seralize
            {
                string json = JsonConvert.SerializeObject(device[i], Formatting.Indented);

                File.WriteAllText(path + "object" + i + ".json", json);

                
            }

            for (int i = 0; i < device.Length; i++) // print
            {
                string json = File.ReadAllText(path + "object" + i + ".json");
                Console.WriteLine(json);
            }

            
            Console.ReadKey();
        }
    }
}
