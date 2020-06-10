using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCMS.Models
{
    public class Content
    {
        
        /// <summary>
        /// primary key
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// text title
        /// </summary>
        public string TextTitle { get; set; }
        
        /// <summary>
        /// text content
        /// </summary>
        public string TextContent { get; set; }
        
        /// <summary>
        /// text status
        /// </summary>
        public int TextStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
    }
}
