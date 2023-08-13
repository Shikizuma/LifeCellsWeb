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
			if (request.Cell.DNA[4] == 'T')
			{
				request.Cell.Energy += 20;
			}
			else if (request.Cell.DNA[4] == 't')
			{
				request.Cell.Energy += 10;
			}
			else if (request.Cell.DNA[4] == 'A')
			{
				request.Cell.Energy += 5;
			}
			else if (request.Cell.DNA[4] == 'a')
			{
				request.Cell.Energy += 2.5;
			}
			else if (request.Cell.DNA[4] == 'G')
			{
				request.Cell.Energy += 8;
			}
			else if (request.Cell.DNA[4] == 'g')
			{
				request.Cell.Energy += 4;
			}
			else if (request.Cell.DNA[4] == 'C')
			{
				request.Cell.Energy += 4;
			}
			else if (request.Cell.DNA[4] == 'c')
			{
				request.Cell.Energy += 3;
			}


			base.LifeRequest(request);
		}
	}
}
