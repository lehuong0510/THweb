﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _13_09web_student.Models
{
    public class Student
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Phải nhập tên")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Tên phải có ít nhất 4 ký tự và tối đa 100 ký tự.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@gmail\.com")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Password bắt buộc phải được nhập")]
        [StringLength(100, MinimumLength = 8)]
       // [Required(ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        public string? Password { get; set; }

        [Required]
        public Branch? Branch { get; set; }//nganh hoc
        [Required(ErrorMessage ="Chọn giới tính")]
        public Gender? Gender { get; set; }
     
        public bool IsRegular { get; set; }//he -true (chinh quy) , false (phi cq)
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Phải nhập địa chỉ")]
        public string? Address { get; set; }
        [Range(typeof(DateTime), "1/1/1963", "31/12/2005")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Nhập đúng ngày sinh trong khoảng thời gian 1/1/1963 - 31/12/2005")]
        public DateTime? DateOfBorth { get; set; }
        [Required(ErrorMessage ="Hãy thêm ảnh!")]
        public IFormFile Img { get; set; }
        [Required(ErrorMessage = "Hãy nhập điểm !")]
       // [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Điểm phải là số ")]
        [Range(0.0,10.0, ErrorMessage = "Điểm phải là kiểu số thực và miền giá trị từ 0.0 đến 10.0")]    
        public double? Diem { get; set; }
    }
}
