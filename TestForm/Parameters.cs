using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
	public class Parameters
	{
		public string key { get; set; } = "";
		public string value { get; set; } = "";
		public string description { get; set; } = "";
		public long type { get; set; } = 0;
		public string type_text { get; set; } = "";
		public bool random { get; set; } = false;
		public string random_text { get; set; } = "";
	}
}
