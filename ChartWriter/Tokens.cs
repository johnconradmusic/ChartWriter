using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartWriter
{
	public static class Tokens
	{
		public static Token N1;
		public static Token b2;
		public static Token N2;
		public static Token b3;
		public static Token N3;
		public static Token N4;
		public static Token b5;
		public static Token N5;
		public static Token b6;
		public static Token N6;
		public static Token b7;
		public static Token N7;

		public static Token sus2;
		public static Token sus4;

		public static Token Major;
		public static Token Minor;
		public static Token Aug;
		public static Token Dim;

		public static Token E_b5;

		public static Token E_7;
		public static Token E_M7;

		public static Token E_b9;
		public static Token E_9;
		public static Token E_s9;

		public static Token E_11;
		public static Token E_s11;

		public static Token E_b13;
		public static Token E_13;

		public static Token Push8;
		public static Token Push16;

		public static Token Delay8;
		public static Token Delay16;

		public static Token Diamond;
		public static Token Staccato;
		public static Token Accent;
		public static Token Tie;

		public static void Init()
		{
			N1 = new("1");
			b2 = new("b2");
			N2 = new("2");
			b3 = new("b3");
			N3 = new("3");
			N4 = new("4");
			b5 = new("b5");
			N5 = new("5");
			b6 = new("b6");
			N6 = new("6");
			b7 = new("b7");
			N7 = new("7");

			sus2 = new("sus2");
			sus4 = new("sus4");

			Major = new("M", "");
			Minor = new("m");
			Aug = new("aug");
			Dim = new("dim");

			E_b5 = new("b5");

			E_7 = new("7");
			E_M7 = new("M7");

			E_b9 = new("b9");
			E_9 = new("9");
			E_s9 = new("#9");

			E_11 = new("11");
			E_s11 = new("#11");

			E_b13 = new("b13");
			E_13 = new("13");

			Push8 = new("<");
			Push16 = new("<<");

			Delay8 = new(">");
			Delay16 = new(">>");

			//Diamond;
			//Staccato;
			//Accent;
			//Tie;
		}


	}
}
