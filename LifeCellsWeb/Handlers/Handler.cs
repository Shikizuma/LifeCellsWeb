using LifeCellsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCellsWeb.Handlers
{
	public abstract class Handler
	{
		protected Handler nextHandler;

		public void SetNextHandler(Handler handler)
		{
			nextHandler = handler;
		}

		public virtual void LifeRequest(RequestModel request)
		{
			if (nextHandler != null)
				nextHandler.LifeRequest(request);

		}
	}
}
