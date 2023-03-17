namespace PasswordGenerator.Models
{
    public class PasswordViewModel
    {
        public int PasswordLength { get; set; }
        public string? PasswordResult { get; set; }

        public bool UpperCase { get; set; }

        public bool Numbers { get; set; }

        public bool SpecialCharacters { get; set; }

    }
}
