using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Mapping
{
	public class MapProfile :Profile
	{
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap(); // Burada Product nesnesi ProductDto nesnesine dönüştürülürken 
            CreateMap<Category, CategoryDto>().ReverseMap(); // ReverseMap dediğimiz için tam tersine dönüşebilmektedir.
			CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
        }
    }
}
