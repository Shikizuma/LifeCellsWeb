using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

		public async void Test()
		{
			//webView.CoreWebView2.PostWebMessageAsJson("123");
			await webView.CoreWebView2.ExecuteScriptAsync("alert(321)");
		}
	}
}
