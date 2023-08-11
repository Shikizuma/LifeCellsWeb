using LifeCellsWeb.Extensions;
using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace LifeCellsWeb.Handlers
{
	internal class DNAHandlerThird : Handler
	{
		static Random random = new Random();
		public override void LifeRequest(RequestModel request)
		{
			if (request.Cell.Life < request.Cell.DNA[5])
			{
				var cell = request.Cell;
				var closed = cell.ClosedCell(request.Cells);
				cell.MoveAwait(closed, random.Next(10, 80));
				request.Cell.Energy -= 5;
			}
			else if (request.Cell.Energy > request.Cell.DNA[6])
			{
				var cell = request.Cell;
				var closed = cell.ClosedCell(request.Cells);
				cell.MoveClose(closed, random.Next(10, 80));
				request.Cell.Energy -= 10;
			}
			else
			{
				var cell = request.Cell;
				var closed = cell.ClosedCell(request.Cells);
				cell.MoveToCentre(new Point(1200, 600), random.Next(10, 80));
				request.Cell.Energy -= 2;
			}

			base.LifeRequest(request);
		}
	}
}
