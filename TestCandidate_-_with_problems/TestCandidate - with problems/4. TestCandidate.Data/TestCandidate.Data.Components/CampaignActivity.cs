using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCandidate.Data.Components
{
    class CampaignActivity:Campaign
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
           /// <summary>
           /// שם
           /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// תיאור
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// סדר הצגה
        /// </summary>
        public int OrderShow { get; set; }
    }
}
