using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using LifeCellsWeb.Controller;
using LifeCellsWeb.Models;

namespace LifeCellsWeb
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{

			Configuration configuration = new Configuration();

			configuration.Configure<CellModel>(cell =>
			{
				cell.Id = Guid.NewGuid();
			});

			InitializeComponent();
		}

		private async void Window_Loaded(object sender, RoutedEventArgs e)
		{
			await Web.EnsureCoreWebView2Async(null);
			Web.CoreWebView2.Settings.IsWebMessageEnabled = true;
			string path = System.IO.Path.Combine(Environment.CurrentDirectory, "Interface", "index.html");
			Web.CoreWebView2.Navigate(path);

			Web.CoreWebView2.AddHostObjectToScript("apiwebcontroller", new ApiWebController(Web));
		}
	}
}
