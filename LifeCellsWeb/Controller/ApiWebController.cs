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
		public void GetPosition()
		{
			var message = new
			{
				left = random.Next(0, 700) + "px",
				top = random.Next(0, 700) + "px",
			};

			var json = JsonSerializer.Serialize(message);

			webView.CoreWebView2.PostWebMessageAsJson(json);
		}
	}
}
