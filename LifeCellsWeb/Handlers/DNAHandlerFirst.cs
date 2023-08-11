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
	internal class DNAHandlerFirst : Handler
	{
		public override void LifeRequest(RequestModel request)
		{
			if (request.Cell.Energy > 100)
			{
			

			}

			base.LifeRequest(request);
		}
	}
}
