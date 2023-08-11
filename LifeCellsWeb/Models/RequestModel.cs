using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCellsWeb.Models
{
	public class RequestModel
	{
		public CellModel Cell { get; set; }
		public List<CellModel> Cells { get; set; }
	}
}
