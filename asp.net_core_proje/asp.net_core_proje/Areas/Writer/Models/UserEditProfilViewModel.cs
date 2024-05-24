namespace asp.net_core_proje.Areas.Writer.Models
{
    public class UserEditProfilViewModel
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
