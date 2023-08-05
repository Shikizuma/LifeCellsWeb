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
	public abstract class BaseController
	{
		protected WebView2 WebView { get; set; }

		public BaseController(WebView2 webView)
        {
            WebView = webView;
        }

        public virtual void Json(object obj, string method)
		{
			var eventModel = new EventControllerModel()
			{
				Data = obj,
				Method = method,
			};

			var json = JsonSerializer.Serialize(eventModel);
			WebView.CoreWebView2.PostWebMessageAsJson(json);
		}
	}
}
