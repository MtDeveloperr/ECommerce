using Dapper;
using ECommerce.Discount.Context;
using ECommerce.Discount.DTOs;
using System.Collections.Generic;

namespace ECommerce.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateCouponAsync(CreateCouponDto createCouponDto)
        {
            string query = "insert into Coupon (Code,Rate,IsActive,ValidDate) values (@code,@rate,@isActive,@validDate";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDto.Code);
            parameters.Add("@rate", createCouponDto.Rate);
            parameters.Add("@isActive", createCouponDto.IsActive);
            parameters.Add("@validDate", createCouponDto.ValidDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            };
        }

        public async Task DeleteCouponAsync(int id)
        {
            string query = "delete drom Coupon where CouponId = @couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            };
        }

        public async Task<List<ResultCouponDto>> GetAllCouponAsync()
        {
           string query = "select * from Coupon";

           using (var connection = _context.CreateConnection())
           {
                var res = await connection.QueryAsync<ResultCouponDto>(query);
                return res.ToList();
           };
            
        }

        public async Task<GetByIdCouponDto> GetByIdCouponAsync(int id)
        {
            string query = "select * from Coupon where CouponId = @couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId",id);
            using (var connection = _context.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<GetByIdCouponDto>(query,parameters);
            };
        }

        public async Task UpdateCouponAsync(UpdateCouponDto updateCouponDto)
        {
            string query = "update Coupon set Code = @code,Rate = @rate,IsActive = @isActive,ValidDate = @validDate where CouponId = @couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateCouponDto.Code);
            parameters.Add("@rate", updateCouponDto.Rate);
            parameters.Add("@isActive", updateCouponDto.IsActive);
            parameters.Add("@validDate", updateCouponDto.ValidDate);
            parameters.Add("@couponId", updateCouponDto.CouponId);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            };
        }
    }
}
