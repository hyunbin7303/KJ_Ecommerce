

using System.Collections.Generic;
using UserIdentity.Models;

namespace UserIdentity.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(LoginRequestModel model);
        IEnumerable<EcUser> GetAll();
        EcUser GetById(string id);
    }
}
