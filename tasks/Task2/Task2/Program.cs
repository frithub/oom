using System;

namespace Task2
{
	public class Switch{
		private ushort interfaces;
		private UInt32 bandwithMBit;

		public Switch(ushort theInterfaces, UInt32 theBandwithMBit){
			
			if (theInterfaces == 0)
				throw new Exception ("Keine Interfaces."); 
			if (theBandwithMBit == 0 )
				throw new Exception ("Ungültige Bandbreite.");
			interfaces = theInterfaces;
			bandwithMBit = theBandwithMBit;

		}
		public ushort Interfaces {
			get { 
				return interfaces;
			}
		}
		public UInt32 BandwithMBit{
			get { 
				return bandwithMBit;
			}
		}
		public void ChangeInterfaces (ushort chInterfaces) {
			interfaces = chInterfaces;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Switch catalyst2960x = new Switch (24, 1000);
			Console.WriteLine ("Interfaces: {0}, Bandbreite: {1} MBIT", catalyst2960x.Interfaces, catalyst2960x.BandwithMBit);
			catalyst2960x.ChangeInterfaces (48);
			Console.WriteLine ("Interfaces: {0}, Bandbreite: {1} MBIT", catalyst2960x.Interfaces, catalyst2960x.BandwithMBit);
			//Console.WriteLine ();

		}
	}
}
