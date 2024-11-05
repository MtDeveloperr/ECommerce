using AutoMapper;

namespace ECommerce.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.GetByIdProductImageDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.ResultProductImageDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.UpdateProductImageDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.CreateProductImageDto>().ReverseMap();

            CreateMap<ECommerce.Catalog.Entites.Product, ECommerce.Catalog.DTOs.ProductDtos.GetByIdProductDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.Product, ECommerce.Catalog.DTOs.ProductDtos.ResultProductDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.Product, ECommerce.Catalog.DTOs.ProductDtos.UpdateProductDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.Product, ECommerce.Catalog.DTOs.ProductDtos.CreateProductDto>().ReverseMap();

            CreateMap<ECommerce.Catalog.Entites.Category, ECommerce.Catalog.DTOs.CategoryDtos.GetByIdCategoryDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.Category, ECommerce.Catalog.DTOs.CategoryDtos.ResultCategoryDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.Category, ECommerce.Catalog.DTOs.CategoryDtos.UpdateCategoryDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.Category, ECommerce.Catalog.DTOs.CategoryDtos.CreateCategoryDto>().ReverseMap();

            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.GetByIdProductImageDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.ResultProductImageDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.UpdateProductImageDto>().ReverseMap();
            CreateMap<ECommerce.Catalog.Entites.ProductImage, ECommerce.Catalog.DTOs.ProductImageDtos.CreateProductImageDto>().ReverseMap();
        }
    }
}
