using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartWriter
{
	public class Token
	{
		public string content;
		public string displayString;


		public Token(string content, string displayString)
		{
			this.content = content;
			this.displayString = displayString;
		}

		public Token(string content)
		{
			this.displayString = content;
			this.content = content;
		}
	}
}
