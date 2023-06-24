using AutoMapper;
using PatikaFinal.Schema.Category;
using PatikaFinal.Schema.Coupon;
using PatikaFinal.Schema.MMProductCategory;
using PatikaFinal.Schema.Order;
using PatikaFinal.Schema.OrderDetail;
using PatikaFinal.Schema.Product;
using PatikaFinal.Schema.User;

namespace PatikaFinal.Schema.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<PatikaFinal.Data.Domain.Category, CategoryResponse>();
            CreateMap<CategoryRequest, PatikaFinal.Data.Domain.Category>();

            CreateMap<PatikaFinal.Data.Domain.User, UserResponse>();
            CreateMap<UserRequest, PatikaFinal.Data.Domain.User>();

            CreateMap<PatikaFinal.Data.Domain.Product, ProductResponse>();
            CreateMap<ProductRequest, PatikaFinal.Data.Domain.Product>();

            CreateMap<PatikaFinal.Data.Domain.MMProductCategory, MMProductCategoryResponse>();
            CreateMap<MMProductCategoryRequest, PatikaFinal.Data.Domain.MMProductCategory>();

            CreateMap<PatikaFinal.Data.Domain.Order, OrderResponse>();
            CreateMap<OrderRequest, PatikaFinal.Data.Domain.Order>();

            CreateMap<PatikaFinal.Data.Domain.Order, OrderResponse>();
            CreateMap<OrderRequest, PatikaFinal.Data.Domain.Order>();

            CreateMap<PatikaFinal.Data.Domain.OrderDetail, OrderDetailResponse>();
            CreateMap<OrderDetailRequest, PatikaFinal.Data.Domain.OrderDetail>();

            CreateMap<PatikaFinal.Data.Domain.Coupon, CouponResponse>();
            CreateMap<CouponRequest, PatikaFinal.Data.Domain.Coupon>();

        }
    }
}
