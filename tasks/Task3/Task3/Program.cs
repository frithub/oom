using System;

namespace Task3
{
	public interface Icomponent {
		//void showTurnedOn (); wie?
		void showDevice ();
	}
	public class Switch : Icomponent {
		private int power;
		private bool turnedOn;
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
			Console.WriteLine ("this is the switch ... "); // name?
		}

	}

	public class Router : Icomponent {
		private int power;
		private bool turnedOn;
		private string name;

		public void showDevice () {
			Console.WriteLine ("this is the router ...  "); // name?
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Icomponent[] devices = new Icomponent[3];
			devices[0] = new Switch(24, 1000, 110, false, "Catalyst2900x");
			devices[1] = new Router();
			devices[2] = new Switch(24, 1000, 110, false, "Catalyst2900y");

			foreach (Icomponent c in devices) {
				c.showDevice ();
			}
		}
	}
}