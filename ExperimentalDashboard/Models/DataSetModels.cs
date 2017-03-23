using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExperimentalDashboard.Models
{
    [Table("Cities")]
    public class CityModel
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    [Table("CityPopulation")]
    public class PopulationModel
    {
        [Key]
        public int CityId { get; set; }
        public Int16 Year { get; set; }
        public int Population { get; set; }
        public Byte certainty { get; set; }
    }

    public class CountryJson
    {
        public Dictionary<string, List<CityPopulationJson>> Items { get; set; }
    }
    public class CityPopulationJson
    {
        public List<string> cities { get; set; }
        public List<int> population { get; set; }
    }

    public class CityPopulationDBContext : DbContext
    {
        public DbSet<CityModel> CityModel { get; set; }

        public DbSet<PopulationModel> PopulationModel { get; set; }
    }

   /* [DataContract]
    public class CityTimeline
    {
        [DataMember]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string Country { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public Int16 Year { get; set; }
        public int Population { get; set; }
        public Byte certainty { get; set; }
    }
  */
}