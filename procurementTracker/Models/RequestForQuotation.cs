using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace procurementTracker.Models
{
	public class RequestForQuotation
	{
		[Key]
		public int requestForQuotationId { get; set; }

		[Column(TypeName ="date")]
		public string requestDate { get; set; }

		[Column(TypeName = "int")]
		public int requestCustomerId { get; set; }

		[Column(TypeName = "nvarchar(1000)")]
		public string requestRemarks { get; set; }

		[Column(TypeName = "date")]
		public string requestThresholdDate { get; set; }

		[Column(TypeName = "nvarchar(1000)")]
		public string requestThreshold { get; set; }

		[Column(TypeName = "nvarchar(1000)")]
		public string requestOfficer { get; set; }

		[Column(TypeName = "date")]
		public string requestProjectDate { get; set; }

		[Column(TypeName = "nvarchar(1000)")]
		public string requestQuoteNumber { get; set; }
	}
}