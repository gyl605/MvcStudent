namespace MvcStudent.Models;
using System.ComponentModel.DataAnnotations;

    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "姓名")]
        [StringLength(300)]
        public string? Name { get; set; }


        [Display(Name = "性别")]
        [StringLength(1)]
        public string? Gender { get; set; }


        [Display(Name = "年龄")]
        [Range(1, 200)]
        public int? Age { get; set; }


        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "体温")]
        [Range(30, 60)]
        public string? Temperature { get; set; }

        [Display(Name = "联系方式")]
        [StringLength(13)]
        public string? Phone { get; set; }



        [Display(Name = "记录日期")]
        public DateTime Date { get; set; }
    }

