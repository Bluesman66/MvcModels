using MvcModels.Infrastructure;
using System.Web.Mvc;

namespace MvcModels.Models
{
	[ModelBinder(typeof(AddressSummaryBinder))]
	public class AdressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}