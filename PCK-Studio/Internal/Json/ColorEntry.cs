using Newtonsoft.Json;

namespace PckStudio.Internal.Json {
	internal class JsonColorEntry {
		[JsonProperty("defaultName", Required = Required.Always)]
		public string DefaultName { get; set; }

		[JsonProperty("isWaterColour", DefaultValueHandling = DefaultValueHandling.Populate)]
		public bool IsWaterColour { get; set; }

		[JsonProperty("variants", DefaultValueHandling = DefaultValueHandling.Populate)]
		public string[] Variants { get; set; }
	}
}
