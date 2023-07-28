using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCellsWeb.Fabrics
{
	internal class MitochondrionFabric : FabricContainer
	{
		static Random random = new Random();
		public static MitochondrionModel CreateMitochondrion()
		{
			int size = random.Next(100, 300);
			var mito =  new MitochondrionModel()
			{
				Style = new StyleModel()
				{
					X = random.Next(20, size - 20) + "px",
					Y = random.Next(20, size - 20) + "px",
					Transform = $"rotate({random.Next(0, 360)}deg)",
				}
			};

			//Type key = typeof(MitochondrionModel);
			//if (Container.ContainsKey(key))
			//{
			//	var appendConfiguration = Container[key];
			//	appendConfiguration(mito);
			//}

			return mito;
		}

		public static List<MitochondrionModel> CreateMitochondrions(int count = 3)
		{
			MitochondrionModel[] mitochondrions = new MitochondrionModel[count];
			for (int j = 0; j < count; j++)
			{
				mitochondrions[j] = CreateMitochondrion();
			}

			return mitochondrions.ToList();
		}
	}
}
