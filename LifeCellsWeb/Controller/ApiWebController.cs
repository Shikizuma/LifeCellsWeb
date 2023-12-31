﻿using LifeCellsWeb.Fabrics;
using LifeCellsWeb.Handlers;
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
		Handler cellHandler;
		public ApiWebController(WebView2 webView) : base(webView) 
		{
			DNAHandlerFirst first = new DNAHandlerFirst();
			DNAHandlerSecond second = new DNAHandlerSecond();
			DNACharacteristicsHandler characteristics = new DNACharacteristicsHandler();
			DNAHandlerThird third = new DNAHandlerThird();

			first.SetNextHandler(second);
			second.SetNextHandler(characteristics);
			characteristics.SetNextHandler(third);

			cellHandler = first;
		}
		
		Random random = new Random();
		public void LoadCells()
		{
			int count = random.Next(2, 10);
			var cells = CellFabric.CreateCells(count);
			Json(cells, "LoadCells");
		}	

		public void UpdateCells(string json)
		{
			List<CellModel> cells = JsonSerializer.Deserialize<List<CellModel>>(json)!;

			cells.ForEach(cell =>
			{
				var request = new RequestModel()
				{
					Cell = cell,
					Cells = cells.Where(c => c.Id != cell.Id).ToList(),
				};
				cellHandler.LifeRequest(request);
			});

			Json(cells, "UpdateCells");
		}
	}
}
