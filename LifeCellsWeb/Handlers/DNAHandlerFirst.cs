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
			if (request.Cell.Energy > request.Cell.DNA[0])
			{
				var style = request.Cell.Style;
				var width = style.Width.GetSize();
				var height = style.Height.GetSize();

				style.Width = $"{width + 5}px";
				style.Height = $"{height + 5}px";
			}

			base.LifeRequest(request);
		}
	}
}
