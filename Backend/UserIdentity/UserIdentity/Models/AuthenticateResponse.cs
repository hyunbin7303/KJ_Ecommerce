namespace UserIdentity.Models
{
    public class AuthenticateResponse : Response
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }

        public AuthenticateResponse(EcUser user, string token)
        {
            Id = user.Id;
            Username = user.UserName;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Token = token;
        }
    }
}
