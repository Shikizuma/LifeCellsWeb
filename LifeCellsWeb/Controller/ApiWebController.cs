using LifeCellsWeb.Fabrics;
using LifeCellsWeb.Models;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LifeCellsWeb.Controller
{
	public class ApiWebController : BaseController
	{
		public ApiWebController(WebView2 webView) : base(webView) {}
		
		Random random = new Random();
		public void LoadCells()
		{
			int count = random.Next(2, 10);
			var cells = CellFabric.CreateCells(count);
			Json(cells, "LoadCells");
		}	

		public async void UpdateCells(string json)
		{
			List<CellModel> cells = JsonSerializer.Deserialize<List<CellModel>>(json)!;

			Regex regex = new Regex("([0-9]+)px");

			cells.ForEach(cell =>
			{
				string px = cell.Style.X;
				var collection = regex.Match(px);
				double newPosition = double.Parse(collection.Groups[1].Value);
				newPosition += 10;
				cell.Style.X = $"{newPosition}px";
			});

			Json(cells, "UpdateCells");
		}
	}
}
