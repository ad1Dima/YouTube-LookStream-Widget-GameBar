using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidgetSampleCS
{
    public class Messages
    {
       

        public Messages(string v1, string v2, string v3)
        {
            this.Title = v1;
            this.Name = v2;
            this.AvatarUrl = v3;
        }

        public string AvatarUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
      //  public string Company { get; set; }

       
    }
  
}
