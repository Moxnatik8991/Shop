using Shop.Abstractions;
using Shop.Domain.Entity;
using Shop.Helpers.FilteringAndPagination;
using System.Linq.Expressions;
using System.Text.Json;

namespace Shop.Services
{
    public class ProductService : IProductServices
    {
        private readonly IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
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
            if (!String.IsNullOrEmpty(searchParam.ColumnFilters))
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
            if (!String.IsNullOrEmpty(searchParam.OrderBy))
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
                var customFilter = CustomExpressionFilter<Product>.CustomFilter(columnFilters, "products");
                filters = customFilter;
            }

            var query = _productRepository.CustomQuery(filters);
            var count = query.Count();
            var filteredData = query.CustomPagination(searchParam.PageNumber, searchParam.PageSize).ToList();

            var pagedList = new PagedList<Product>(filteredData, count, searchParam.PageNumber, searchParam.PageSize);

            if (pagedList != null)
            {
                //Response.AddPaginationHeader(pagedList.MetaData);
            }

            return pagedList;
        }
    }
}
