using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WirelessMediaApplication.Models
{
    [MetadataType(typeof(DobavljacMetaData))]
    public partial class Dobavljac
    {


    }
    public class DobavljacMetaData
    {
        [JsonIgnore]
        public virtual ICollection<Proizvod> Proizvod { get; set; }
    }
}