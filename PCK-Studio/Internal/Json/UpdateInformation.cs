using Newtonsoft.Json;

namespace PckStudio.Internal.Json {
	internal class UpdateInformation {
		[JsonProperty("version")]
		public string Version { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("changelog")]
		public string Changelog { get; set; }

		[JsonProperty("mandatory")]
		public bool Mandatory { get; set; }
	}
}