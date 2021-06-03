namespace BLL.DTOs.User
{
    public class SignedInUserDto
    {
        public UserDto User { get; set; }
        public string Token { get; set; }
        
        public SignedInUserDto(UserDto user, string token)
        {
            User = user;
            Token = token;
        }
    }
}