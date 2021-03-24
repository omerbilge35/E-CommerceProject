using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kimyon.Models
{
    public class Adviewmodel
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_image { get; set; }
        public string product_description { get; set; }
        public Nullable<int> product_price { get; set; }
        public Nullable<int> product_fk_category { get; set; }
        public Nullable<int> product_fk_user { get; set; }
        public int category_id { get; set; }
        public string category_name { get; set; }
        public string u_name { get; set; }
        public string u_image { get; set; }
        public string u_contact { get; set; }



    }
}