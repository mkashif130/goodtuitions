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
    
    public partial class cor_compaigns
    {
        public cor_compaigns()
        {
            this.cor_leads = new HashSet<cor_leads>();
        }
    
        public int CampaignId { get; set; }
        public string CampaignTitle { get; set; }
        public string CampaignDescription { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<cor_leads> cor_leads { get; set; }
    }
}
