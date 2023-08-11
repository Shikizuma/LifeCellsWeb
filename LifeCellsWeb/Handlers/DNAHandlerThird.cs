using LifeCellsWeb.Extensions;
using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LifeCellsWeb.Handlers
{
	internal class DNAHandlerThird : Handler
	{
		public override void LifeRequest(RequestModel request)
		{
			if (request.Cell.Life < request.Cell.DNA[5])
			{
				double x = request.Cell.Style.X.GetSize();
				request.Cell.Style.X = $"{x + 10}px";

				request.Cell.Energy -= 10;
			}

			base.LifeRequest(request);
		}
	}
}
