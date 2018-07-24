using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WirelessMediaApplication.Models
{
    [MetadataType(typeof(KategorijaMetaData))]
    public partial class Kategorija
    {


    }
    public class KategorijaMetaData
    {
        [JsonIgnore]
        public virtual ICollection<Proizvod> Proizvod { get; set; }

    }
}