using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCellsWeb.Handlers
{
	internal class DNACharacteristicsHandler : Handler
	{
		public override void LifeRequest(RequestModel request)
		{
			if (request.Cell.DNA[4] == 'T')
			{
				request.Cell.Life += 3;
			}
			else if (request.Cell.DNA[4] == 't')
			{
				request.Cell.Life += 1.5;
			}
			else if (request.Cell.DNA[4] == 'A')
			{
				request.Cell.Life += 8;
			}
			else if (request.Cell.DNA[4] == 'a')
			{
				request.Cell.Life += 4;
			}
			else if (request.Cell.DNA[4] == 'G')
			{
				request.Cell.Life += 8;
			}
			else if (request.Cell.DNA[4] == 'g')
			{
				request.Cell.Life += 4;
			}
			else if (request.Cell.DNA[4] == 'C')
			{
				request.Cell.Life += 10;
			}
			else if (request.Cell.DNA[4] == 'c')
			{
				request.Cell.Life += 5;
			}


			base.LifeRequest(request);
		}
	}
}
