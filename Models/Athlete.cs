using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BioFan.Models
{
	public class Athlete
	{
		public string Id { get; set; }
		public string Title { get; set; }

		[JsonPropertyName("img")]
		public string Image { get; set; }

		public string Description { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }

		public override string ToString() => JsonSerializer.Serialize<Athlete>(this);
        
    }
}

