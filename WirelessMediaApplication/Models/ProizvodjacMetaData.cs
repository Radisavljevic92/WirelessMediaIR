using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WirelessMediaApplication.Models
{
    [MetadataType(typeof(ProizvodjacMetaData))]

    public partial class Proizvodjac
    {


    }


    public class ProizvodjacMetaData
    {
        [JsonIgnore]
        public virtual ICollection<Proizvod> Proizvod { get; set; }

      

    }
}