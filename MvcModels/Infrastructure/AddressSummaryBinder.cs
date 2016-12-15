using MvcModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModels.Infrastructure
{
	public class AddressSummaryBinder : IModelBinder
	{
		public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
		{
			AdressSummary model = (AdressSummary)bindingContext.Model ?? new AdressSummary();
			model.City = GetValue(bindingContext, "City");
			model.Country = GetValue(bindingContext, "Country");
			return model;
		}

		private string GetValue(ModelBindingContext context, string name)
		{
			name = (context.ModelName.Length == 0 ? string.Empty : context.ModelName + ".") + name;

			ValueProviderResult result = context.ValueProvider.GetValue(name);
			if (result == null || result.AttemptedValue == "")
			{
				return "<Не указано>";
			}
			else
			{
				return (string)result.AttemptedValue;
			}
		}
	}
}