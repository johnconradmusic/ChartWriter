using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartWriter
{
	public class Chord
	{
		public Root Root;
		public int Length;
		public SlashNote SlashNote;
		public Quality Quality;
		public List<Extension> Extensions = new();
		public Offset Offset;
		public Articulation Articulation;

		public static Chord ParseFromString(string str)
		{
			Chord chord = new();

			Root root;
			if (str[0] == 'b')
			{
				root = new(str.Substring(0, 2), str.Substring(0, 2));
				str = str.Substring(2);
			}
			else
			{
				root = new(str[0].ToString(), str[0].ToString());
			}
			chord.Root = root;



			return new Chord();
		}
	}
}
