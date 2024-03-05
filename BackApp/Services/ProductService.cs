using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System;
using System.Linq.Expressions;
using System.Text.Json;
using Shop.BackApp.Repository;
using Shop.BackApp.Helpers.FilteringAndPagination;
using Shop.BackApp.Services.Interfaces;
using Shop.BackApp.Domain.Entity;

namespace Shop.BackApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IBaseRepository<Product> _productRepository;
        public ProductService(IBaseRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();

            return products;
        }

        public async Task<IEnumerable<Product>> GetWithFilteringAndPagination(SearchParams searchParam)
        {
            List<ColumnFilter> columnFilters = new List<ColumnFilter>();
            if (!string.IsNullOrEmpty(searchParam.ColumnFilters))
            {
                try
                {
                    columnFilters.AddRange(JsonSerializer.Deserialize<List<ColumnFilter>>(searchParam.ColumnFilters));
                }
                catch (Exception)
                {
                    columnFilters = new List<ColumnFilter>();
                }
            }

            List<ColumnSorting> columnSorting = new List<ColumnSorting>();
            if (!string.IsNullOrEmpty(searchParam.OrderBy))
            {
                try
                {
                    columnSorting.AddRange(JsonSerializer.Deserialize<List<ColumnSorting>>(searchParam.OrderBy));
                }
                catch (Exception)
                {
                    columnSorting = new List<ColumnSorting>();
                }
            }

            Expression<Func<Product, bool>> filters = null;

            //First, we are checking our SearchTerm. If it contains information we are creating a filter.
            var searchTerm = "";
            if (!string.IsNullOrEmpty(searchParam.SearchTerm))
            {
                searchTerm = searchParam.SearchTerm.Trim().ToLower();
                filters = x => x.Name.ToLower().Contains(searchTerm);
            }

            // Then we are overwriting a filter if columnFilters has data.
            if (columnFilters.Count > 0)
            {
                var customFilter = CustomExpressionFilter<Product>.CustomFilter(columnFilters, nameof(Product));
                filters = customFilter;
            }

            var query = _productRepository.CustomQuery(filters);
            var count = query.Count();

            if (columnSorting.Count() > 0)
            {
                query = CustomExpressionSorting<Product>.AddSorting(query, columnSorting, nameof(Product));
            }

            // Check Sql
            var filteredData23 = query.CustomPagination(searchParam.PageNumber, searchParam.PageSize);
            var sql2 = filteredData23.ToQueryString();
            //

            var filteredData = query.CustomPagination(searchParam.PageNumber, searchParam.PageSize).ToList();


            // Check Sql
            //var filteredData2 = query.CustomPagination(searchParam.PageNumber, searchParam.PageSize);
            //var sql = filteredData2.ToQueryString();
            //


            var pagedList = new PagedList<Product>(filteredData, count, searchParam.PageNumber, searchParam.PageSize);

            if (pagedList != null)
            {
                //Response.AddPaginationHeader(pagedList.MetaData);
            }

            return pagedList;
        }


        public async Task<Product> GetAsync(Guid id)
        {
            return await _productRepository.GetAsync(id);
        }
    }
}
