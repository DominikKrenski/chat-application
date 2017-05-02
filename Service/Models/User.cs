using Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    [Table("users")]
    [PasswordMatchValidator("Password", "PasswordConfirm", ErrorMessage = "Password and password confirmation are not equal")]
    public class User
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("login")]
        [StringLength(10)]
        [MinLength(3, ErrorMessage = "Login must consist of minimum 3 characters")]
        [MaxLength(10, ErrorMessage = "Login must consist of maximum 10 characters")]
        [RegularExpression(@"^[a-zA-Z0-9ĘęÓóĄąŚśŁłŻżŹźĆćŃń_\-]*$", ErrorMessage = @"Login can consist of lettters, digits and _ - signs")]
        [Required(ErrorMessage = "Login cannot be blank")]
        public string Login { get; set; }

        [Column("password")]
        [StringLength(60)]
        [Required(ErrorMessage = "Password cannot be blank")]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Password confirmation cannot be blank")]
        public string PasswordConfirm { get; set; }

        [Column("name")]
        [StringLength(50)]
        [MinLength(3, ErrorMessage = "Name must consist of minimum 3 characters")]
        [MaxLength(50, ErrorMessage = "Name must consist of maximum 50 characters")]
        [RegularExpression(@"^[a-zA-ZĘęÓóĄąŚśŁłŻżŹźĆćŃń]*$", ErrorMessage = "Name must consist of letters only")]
        [Required(ErrorMessage = "Name cannot be blank")]
        public string Name { get; set; }

        [Column("surname")]
        [StringLength(50)]
        [MinLength(3, ErrorMessage = "Surname must consist of minimum 3 characters")]
        [MaxLength(50, ErrorMessage = "Surname must consist of maximum 50 characters")]
        [RegularExpression(@"^[a-zA-Z0-9ĘęÓóĄąŚśŁłŻżŹźĆćŃń\-]*$", ErrorMessage = "Surname must consist of letters and - sign only")]
        [Required(ErrorMessage = "Surname cannot be blank")]
        public string Surname { get; set; }

        [Column("sex")]
        [Required(ErrorMessage = "Sex cannot be blank")]
        public string Sex { get; set; }

        [Column("age")]
        [RegularExpression(@"[0-9]{1,2}", ErrorMessage = "Age must consist of digits only")]
        [Required(ErrorMessage = "Age cannot be blank")]
        public int Age { get; set; }
    }
}
