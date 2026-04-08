class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("hasil penambahan : {0} + {1} = {2}",a,b,Penambahan(a,b));
		Console.WriteLine("hasil penambahan : {0} + {1} = {2}",a,b,Penambahan(a,b));
		Console.WriteLine("\n Tekan apapun untuk keluar ");
		Console.ReadKey();
		
	}
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	static int Penguragan(int a, int b)
	{
		return a - b;
	}
}