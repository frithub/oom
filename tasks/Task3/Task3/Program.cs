using System;

namespace Task3
{
	public interface Icomponent {
		void showTurnedOn (bool powerOn); //arguments?
		void showDevice ();
	}
	public class Switch : Icomponent {
		private int power;
		public bool turnedOn;
		private string name;
		private ushort interfaces;
		private UInt32 bandwithMBit;

		public Switch(ushort theInterfaces, UInt32 theBandwithMBit, int watt, bool on, string switchName){

			if (theInterfaces == 0)
				throw new Exception ("Keine Interfaces."); 
			if (theBandwithMBit == 0 )
				throw new Exception ("Ungültige Bandbreite.");
			interfaces = theInterfaces;
			bandwithMBit = theBandwithMBit;
			power = watt; 
			turnedOn = on;
			name = switchName;
		}


		public void showDevice () {
			Console.WriteLine ("this is the switch ... " + name); // name?
		}
		public void showTurnedOn (bool powerOn){
			if (powerOn == true) 
				Console.WriteLine("Switched on.");
			else 
				Console.WriteLine("Switched off.");
		}
		public ushort Interfaces {
			get { 				return interfaces;}
		}
		public UInt32 BandwithMBit {
			get {return bandwithMBit; }
		}
	}



	public class Router : Icomponent {
		private int power;
		private bool turnedOn;
		private string name;

		public void showDevice () {
			Console.WriteLine ("this is the router ...  "); // name?
		}
		public void showTurnedOn (bool powerOn){
			if (powerOn == true)
				Console.WriteLine ("Switched on.");
			else
				Console.WriteLine ("Switched off.");
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Icomponent[] devices = new Icomponent[3];
			devices[0] = new Switch(24, 1000, 110, false, "Catalyst2960-L");
			devices[1] = new Router();
			devices[2] = new Switch(24, 1000, 110, false, "Catalyst2960-X");

			foreach (Icomponent c in devices) {
				c.showDevice ();
				c.showTurnedOn(true);
			}
			//Console.WriteLine(devices[0].)
		}
	}
}