namespace RpgMvc.Models
{
    public class UsuarioViewModel
    {
        public int id { get; set; }
        public string Username { get; set;} = string.Empty;

        public string PasswordString { get; set; } = string.Empty;

        public byte[]? Foto { get; set; }

        public string Perfil { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        
    }
}