using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartWriter
{
	[Serializable]
	public class Chart
	{
		public int BeatsPerMeasure = 4;
		public int NoteValueForBeat = 4;
		
		public int MeasuresPerLine = 4;

		public List<Measure> Measures;

		public void Test()
		{
			Measure m;
			Measures.Add(m = new Measure());
		}
	}
}
