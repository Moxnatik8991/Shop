namespace Shop.Helpers.FilteringAndPagination
{
    public class SearchParams : PaginationParams
    {
        /// <summary>
        /// Sorting 
        /// </summary>
        public string? OrderBy { get; set; }

        /// <summary>
        /// Custom Search on back 
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// Filters 
        /// </summary>
        public string? ColumnFilters { get; set; }
    }
}
