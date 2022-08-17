using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmailEditor.Models
{
    public class RichTextEditorViewModel
    {
        [AllowHtml]
        [Display(Name = "Message")]
        public string Body { get; set; }

        public string Subject { get; set; }

        public List<SelectListItem> selectedListItems { get; set; }

        [Display(Name ="Choose Template")]
        public string template { get; set; }

    }
}