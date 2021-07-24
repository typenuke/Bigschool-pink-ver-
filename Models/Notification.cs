using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BigSchool.Models
{
    public class Notification
    {
        [Key]
        [Column(Order = 1)]
        public string Id { get; set; }
        public DateTime DateTime { get; set;}
        public Course Course;
        public NotificationType Type;
    }
}