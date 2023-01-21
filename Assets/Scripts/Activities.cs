using Newtonsoft.Json;
using System;
using System.Collections.Generic;

[Serializable]
public class Activities
{
	[JsonProperty(PropertyName = "activityId")]
	public int activityId { get; set; }

	[JsonProperty(PropertyName = "name")]
	public string Name { get; set; }

	[JsonProperty(PropertyName = "description")]
	public string Description { get; set; }

	[JsonProperty(PropertyName = "finalMessageOK")]
	public string FinalMessageOK { get; set; }

	[JsonProperty(PropertyName = "finalMessageError")]
	public string FinalMessageError { get; set; }

	[JsonProperty(PropertyName = "maxTime")]
	public float MaxTime { get; set; }

	[JsonProperty(PropertyName = "owner")]
	public string Owner { get; set; }

}