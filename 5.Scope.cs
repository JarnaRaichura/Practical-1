using System;
namespace P1
{
	public class Scope{
	static int j = 430;
	public static void Main()
	{
		int j =900;
		Console.WriteLine("j1:{0} and j2:{1}" ,j , Scope.j);
        Console.ReadLine();
	}
    }
}