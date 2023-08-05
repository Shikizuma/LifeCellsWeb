using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LifeCellsWeb.Models
{
	public class CellModel
	{
		[JsonPropertyName("id")]
		public Guid Id { get; set; }
		[JsonPropertyName("life")]
		public double Life { get; set; }	
		[JsonPropertyName("energy")]
		public double Energy { get; set; }
		[JsonPropertyName("dna")]
		public string DNA { get; set; }
		[JsonPropertyName("style")]
		public StyleModel Style { get; set; }
		[JsonPropertyName("mitochondrions")]
		public List<MitochondrionModel> Mitochondrions { get; set; }
		[JsonPropertyName("lysosomes")]
		public List<LysosomeModel> Lysosomes { get; set; }
	}
}
