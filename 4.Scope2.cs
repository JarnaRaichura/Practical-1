using System;
namespace P1
{
	class Scope2
	{
		public static void Main()
		{
			int j=532;
			for(int i=0;i<15;i++)
			{
				int j=0;
				Console.WriteLine(i);
			}
		}
	}
}