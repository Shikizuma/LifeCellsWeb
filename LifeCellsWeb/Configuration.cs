using LifeCellsWeb.Fabrics;
using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCellsWeb
{
	internal class Configuration : FabricContainer
	{
		protected static Dictionary<string, string> Configs { get; set; }

		static Configuration()
		{
			Configs = new Dictionary<string, string>();
			Container = new Dictionary<Type, Action<object>>();
		}

		public void Configure<T>(Action<T> action)
		{
			Action<object> configurationInitialize = (obj) =>
			{
				T config = (T)obj;
				action(config);
            };

			Type key = typeof(T);
			Container[key] = configurationInitialize;
		}

		public string this[string key]
		{
			get
			{
				if (Configs.TryGetValue(key, out string? result))
				{
					return result;
				}
				return "";
			}
		}
	}
}
