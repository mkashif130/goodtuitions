//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class cor_leads
    {
        public int LeadId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string EmailId { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Source { get; set; }
        public int CampaignId { get; set; }
    
        public virtual cor_compaigns cor_compaigns { get; set; }
    }
}
