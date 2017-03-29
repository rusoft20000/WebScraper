using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WebScraper
    {


    public class H1_list 
    
    
    {
        [Key]
        public string Url { get; set; }
        public string FieldName { get; set; }


    }


       public class DataScraping
        {
            public int Id { get; set; }
            public string Url { get; set; }
            public string FieldName { get; set; }
            public string FieldValue { get; set; }
            public string ParentUrl { get; set; }
            public string ParentField { get; set; }
            public string ParentValue { get; set; }
            public int Level { get; set; }
            public string LocalUrl { get; set; }
          //  public DateTime DateCreated { get; set; }


        }


    public class Project
    {
        public int Id { get; set; }
        public string ProjectURL { get; set; }
        public string ProjectName { get; set; }
        public string MediaFolder { get; set; }
    }


}