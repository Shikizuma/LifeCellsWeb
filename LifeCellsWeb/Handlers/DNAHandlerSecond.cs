using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LifeCellsWeb.Handlers
{
	internal class DNAHandlerSecond : Handler
	{

		public override void LifeRequest(RequestModel request)
		{
			if (request.Cell.Energy > 50)
			{
			
			}

			base.LifeRequest(request);
		}
	}
}
