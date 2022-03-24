using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllBasicsDemos
{
    internal class Denomination
    {
        static void Main(string[] args)
        {
            int amt = Convert.ToInt32(Console.ReadLine());
            int twth=0,onth=0,fivh=0,twh=0,onh=0,fifty=0,twenty=0,ten=0,fiv=0;
            //int newamt;
			if (amt > 2000)
				twth = amt / 2000;
            Console.WriteLine("2000 " + twth);
			amt = amt - 2000 * twth;
			if (amt >= 1000)
				onth = amt / 1000;
            Console.WriteLine("1000 " + onth);
			amt = amt - 1000 * onth;
			if (amt > 500)
				fivh = amt / 500;
            Console.WriteLine("500 " + fivh);
			amt = amt - 500 * fivh;
			if (amt >= 200)
				twh = amt / 200;
            Console.WriteLine("200 " + twh);
			amt = amt - 200 * twh;
			if (amt >= 100)
				onh = amt / 100;
            Console.WriteLine("100 " + onh);
			amt = amt - 100 * onh;
			if (amt >= 50)
				fifty = amt / 50;
            Console.WriteLine("50 " + fifty);
			amt = amt - 50 * fifty;
			if (amt >= 20)
				twenty = amt / 20;
            Console.WriteLine("20 " + twenty);
			amt = amt - 20 * twenty;
			if (amt >= 10)
				ten = amt / 10;
            Console.WriteLine("10 " + ten);
			amt = amt - 10 * ten;
			if (amt >= 5)
				fiv = amt / 5;
            Console.WriteLine("5 " + fiv);
			amt = amt - 5 * fiv;

		}

    }
}
