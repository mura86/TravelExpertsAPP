using System;

namespace TravelExpertsData
{
    public class PackageDTO
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal? PkgBasePrice { get; set; }
        public decimal? PkgAgencyCommission { get; set; }
    }
}