using LifeCellsWeb.Fabrics;
using LifeCellsWeb.Models;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LifeCellsWeb.Controller
{
	public class ApiWebController
	{
		WebView2 webView;
		public ApiWebController(WebView2 webView) 
		{
			this.webView = webView;
		}
		
		Random random = new Random();
		public void LoadCells()
		{
			int count = random.Next(1, 10);

			var cells = CellFabric.CreateCells(count);

			var json = JsonSerializer.Serialize(cells);

			webView.CoreWebView2.PostWebMessageAsJson(json);
		}	
	}
}
