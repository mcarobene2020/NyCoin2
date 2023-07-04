using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NycoinWebApp.Models
{
        //DataContract for Serializing Data - required to serve in JSON format
    [DataContract]
    public class DataPointCandle
    {
        
        public DataPointCandle(System.DateTime x, double[] y)
        {
            this.X = x;
            this.Y = y;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "x")]
        public Nullable<System.DateTime> X = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public double[] Y = null;
    }
}
