using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartWriter
{
	public class Measure
	{
		public List<Chord> Chords = new();

		public void AddChord(Chord chord)
		{
			Chords.Add(chord);
		}

	}
}
