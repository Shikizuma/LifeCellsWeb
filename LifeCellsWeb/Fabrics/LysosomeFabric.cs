using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCellsWeb.Fabrics
{
	internal class LysosomeFabric : FabricContainer
	{
		static Random random = new Random();
		public static LysosomeModel CreateLysosome()
		{
			int size = random.Next(100, 300);
			var lys = new LysosomeModel()
			{
				Style = new StyleModel()
				{
					X = random.Next(20, size - 20) + "px",
					Y = random.Next(20, size - 20) + "px",
					Transform = $"rotate({random.Next(0, 360)}deg)",
				}
			};

			//Type key = typeof(LysosomeModel);
			//if (Container.ContainsKey(key))
			//{
			//	var appendConfiguration = Container[key];
			//	appendConfiguration(lys);
			//}

			return lys;
		}

		public static List<LysosomeModel> CreateLysosomes(int count = 1)
		{
			LysosomeModel[] lysosomes = new LysosomeModel[count];
			for (int j = 0; j < count; j++)
			{
				lysosomes[j] = CreateLysosome();
			}

			return lysosomes.ToList();   
		}
	}
}
