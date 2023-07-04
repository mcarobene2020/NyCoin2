using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NycoinWebApp.Models
{
	//DataContract for Serializing Data - required to serve in JSON format
	[DataContract]
	public class DataPointTime
	{
		public DataPointTime(double y, string label)
		{
			this.Y = y;
			this.Label = label;
		}

		public DataPointTime(System.DateTime x, double y)
		{
			this.X = x;
			this.Y = y;
		}
		

		public DataPointTime(System.DateTime x, double y, string label)
		{
			this.X = x;
			this.Y = y;
			this.Label = label;
		}

		public DataPointTime(System.DateTime x, double y, double z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		public DataPointTime(System.DateTime x, double y, double z, string label)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.Label = label;
		}


		//Explicitly setting the name to be used while serializing to JSON. 
		[DataMember(Name = "label")]
		public string Label = null;

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "y")]
		public Nullable<double> Y = null;

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "x")]
		public Nullable<System.DateTime> X = null;

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "z")]
		public Nullable<double> Z = null;
	}
}