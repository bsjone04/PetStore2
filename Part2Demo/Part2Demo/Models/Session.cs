using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part2Demo.Models
{
    public class Session
    {

        public Int32 SessionID { get; set; }


        [Required()]
        [StringLength(maximumLength: 20, MinimumLength = 1)]
        public String Title { get; set; }

        [Required()]
        [StringLength(maximumLength: 2000, MinimumLength = 1)]
        [DataType(DataType.MultilineText)]
        [AllowHtml()]
        public String Abstract { get; set; }


        public virtual Speaker Speaker { get; set; }

        public Int32 SpeakerID { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}
