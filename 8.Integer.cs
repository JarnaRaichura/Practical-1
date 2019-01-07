using System;
namespace P1
{
	class IntType
	{
		public static void Main()
		{
			//Signed Variables
			sbyte sb = 33;//signed byte 8 bit
			short s =33 ;//16 bit 
			int i = 33;//32 bit 
			long l = 33L;//these characters define the type of integer that we have

			//Unsigned Variables
			byte b = 33;
			ushort us = 33;
			uint ui = 33U;
			ulong ul = 33UL;
			us = (ushort)ul;//UL and ul are same 

			Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", sb,s,i,l,b,us,ui,ul);

		}
	}
}