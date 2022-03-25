using System;

/// <summary>
/// use of out variable
/// </summary>
namespace Day4
{
	public class outvar
	{
		public calculation(int a, int b, out int add, out int sub, out int mul)
		{
			add = a + b;
			sub = a - b;
			mul = a * b;
		}
	}
}
