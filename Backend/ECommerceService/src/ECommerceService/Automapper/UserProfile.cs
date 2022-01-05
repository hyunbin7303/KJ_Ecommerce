using AutoMapper;
using ECommerce.Core.Models;
using ECommerce.Query;

namespace ECommerceService.Automapper
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<User, CreateUserDTO>().ReverseMap();
		}
	}
}
