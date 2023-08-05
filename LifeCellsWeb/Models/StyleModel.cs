using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LifeCellsWeb.Models
{
	public class StyleModel
	{
		[JsonPropertyName("width")]
		public string Width { get; set; }
		[JsonPropertyName("height")]
		public string Height { get; set; }
        [JsonPropertyName("left")]
        public string X { get; set; }
		[JsonPropertyName("top")]
		public string Y { get; set; }
		[JsonPropertyName("transform")]
		public string Transform { get; set; }
    }
}
