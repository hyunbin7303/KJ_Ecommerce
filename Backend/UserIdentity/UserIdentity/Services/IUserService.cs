

using System.Collections.Generic;
using UserIdentity.Models;

namespace UserIdentity.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<EcUser> GetAll();
        EcUser GetById(int id);
    }
}
