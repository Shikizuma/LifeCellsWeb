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
		static Random random = new Random();
		Regex regex = new Regex("([0-9]+)px");

		public override StyleModel LifeRequest(CellModel cell)
		{
			if (cell.Energy > 100)
			{
				string px = cell.Style.X;
				var collection = regex.Match(px);
				double newPosition = double.Parse(collection.Groups[1].Value);
				newPosition += 10;
				cell.Style.X = $"{newPosition}px";

				cell.Energy -= 10;

				return cell.Style;
			}

			return base.LifeRequest(cell);
		}
	}
}
