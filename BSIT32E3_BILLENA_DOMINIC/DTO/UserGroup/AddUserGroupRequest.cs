using System.ComponentModel.DataAnnotations;

namespace BSIT32E3_BILLENA_DOMINIC.DTO.Users
{
    public class AddUserGroupRequest
    {
        [Required]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }




    }

    public class EditUserGroupRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "XXXX")]

        public string? Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

    }
}
