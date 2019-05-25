using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class JiaoQiu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string DuiMing { get; set; }
        public string Half { get; set; }
        public string Time { get; set; }
        public string ChuPanJiao { get; set; }
        public string DangQianJiao { get; set; }
        public string SheZheng { get; set; }
        public string ShePian { get; set; }
        public string ChuPanRang { get; set; }
        public string DangQianRang { get; set; }
    }
}
