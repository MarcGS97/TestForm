using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
	public class Configuracion
	{
		public string url { get; set; } = "";
		public int method { get; set; } = 0;
		public long time { get; set; } = 0;
		public long queries { get; set; } = 0;

		public List<Parameters> parameters = new List<Parameters>();
	}
}
