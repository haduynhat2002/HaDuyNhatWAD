using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WADHaDuyNhat.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExamDate { get; set; }
        public int Duration { get; set; }
        public string ClassRoom { get; set; }
        public string Faculty { get; set; }
        public string Status { get; set; }
    }
}