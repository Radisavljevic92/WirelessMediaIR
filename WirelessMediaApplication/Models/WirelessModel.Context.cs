﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WirelessMediaApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WirelessMedia2018Entities : DbContext
    {
        public WirelessMedia2018Entities()
            : base("name=WirelessMedia2018Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dobavljac> Dobavljac { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Proizvodjac> Proizvodjac { get; set; }
        public virtual DbSet<Proizvod> Proizvod { get; set; }
    
        public virtual ObjectResult<VratiProizvode_Result> VratiProizvode()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VratiProizvode_Result>("VratiProizvode");
        }
    
        public virtual ObjectResult<VratiProizvodPoId_Result> VratiProizvodPoId(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VratiProizvodPoId_Result>("VratiProizvodPoId", idParameter);
        }
    
        public virtual ObjectResult<UpdateProizvoda_Result> UpdateProizvoda(Nullable<int> id, string nazivProizvoda, string opisProizvoda, Nullable<decimal> cenaProizvoda)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nazivProizvodaParameter = nazivProizvoda != null ?
                new ObjectParameter("NazivProizvoda", nazivProizvoda) :
                new ObjectParameter("NazivProizvoda", typeof(string));
    
            var opisProizvodaParameter = opisProizvoda != null ?
                new ObjectParameter("OpisProizvoda", opisProizvoda) :
                new ObjectParameter("OpisProizvoda", typeof(string));
    
            var cenaProizvodaParameter = cenaProizvoda.HasValue ?
                new ObjectParameter("CenaProizvoda", cenaProizvoda) :
                new ObjectParameter("CenaProizvoda", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UpdateProizvoda_Result>("UpdateProizvoda", idParameter, nazivProizvodaParameter, opisProizvodaParameter, cenaProizvodaParameter);
        }
    }
}
