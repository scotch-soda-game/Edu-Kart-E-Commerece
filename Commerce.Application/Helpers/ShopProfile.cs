using AutoMapper;
using Commerce.Domain;
using Commerce.Domain.Identity;
using Commerce.Application.Dtos;

namespace Commerce.Application.Helpers
{
    public class ShopProfile : Profile
    {
        public ShopProfile()
        {
            CreateMap<CartItem, CartItemDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserRegisterDto>().ReverseMap();
            CreateMap<User, UserLoginDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<UserRole, UserRoleDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        }
    }
}
