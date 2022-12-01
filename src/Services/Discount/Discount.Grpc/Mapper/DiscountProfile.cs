﻿using AutoMapper;
using discount.Grpc.Protos;
using Discount.Grpc.Entities;

namespace Discount.Grpc.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}