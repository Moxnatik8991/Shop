using System.Linq.Expressions;

namespace Shop.Helpers.FilteringAndPagination
{
    public static class CustomExpressionFilter<T> where T : class
    {
        public static Expression<Func<T, bool>> CustomFilter(List<ColumnFilter> columnFilters, string className)
        {
            Expression<Func<T, bool>> filters = null;
            try
            {
                // Create the parameter expression for the input data
                var parameter = Expression.Parameter(typeof(T), className);

                // Build the filter expression dynamically
                Expression filterExpression = null;
                foreach (var filter in columnFilters)
                {
                    var property = Expression.Property(parameter, filter.id);

                    Expression comparison;

                    if (property.Type == typeof(string))
                    {
                        var constant = Expression.Constant(filter.value);
                        comparison = Expression.Call(property, "Contains", Type.EmptyTypes, constant);
                    }
                    else if (property.Type == typeof(double))
                    {
                        if (!string.IsNullOrEmpty(filter.lowerValue) && !string.IsNullOrEmpty(filter.upperValue))
                        {
                            var lowerBound = Expression.Constant(Convert.ToDouble(filter.lowerValue));
                            var upperBound = Expression.Constant(Convert.ToDouble(filter.upperValue));

                            var lowerConstant = Expression.Constant(lowerBound);
                            var upperConstant = Expression.Constant(upperBound);

                            var greaterThanOrEqual = Expression.GreaterThanOrEqual(property, lowerConstant);
                            var lessThanOrEqual = Expression.LessThanOrEqual(property, upperConstant);

                            //// Combine two conditions using AndAlso
                            comparison = Expression.AndAlso(greaterThanOrEqual, lessThanOrEqual);
                        }
                        else
                        {
                            var constant = Expression.Constant(Convert.ToDouble(filter.value));
                            comparison = Expression.Equal(property, constant);
                        }
                    }
                    else if (property.Type == typeof(decimal))
                    {
                        if (!string.IsNullOrEmpty(filter.lowerValue) && !string.IsNullOrEmpty(filter.upperValue))
                        {
                            var lowerBound = Expression.Constant(Convert.ToDecimal(filter.lowerValue));
                            var upperBound = Expression.Constant(Convert.ToDecimal(filter.upperValue));

                            var lowerConstant = Expression.Constant(lowerBound);
                            var upperConstant = Expression.Constant(upperBound);

                            var greaterThanOrEqual = Expression.GreaterThanOrEqual(property, lowerConstant);
                            var lessThanOrEqual = Expression.LessThanOrEqual(property, upperConstant);

                            //// Combine two conditions using AndAlso
                            comparison = Expression.AndAlso(greaterThanOrEqual, lessThanOrEqual);
                        }
                        else
                        {
                            var constant = Expression.Constant(Convert.ToDecimal(filter.value));
                            comparison = Expression.Equal(property, constant);
                        }

                    }
                    else if (property.Type == typeof(Guid))
                    {
                        var constant = Expression.Constant(Guid.Parse(filter.value));
                        comparison = Expression.Equal(property, constant);
                    }
                    else
                    {
                        var constant = Expression.Constant(Convert.ToInt32(filter.value));
                        comparison = Expression.Equal(property, constant);
                    }


                    filterExpression = filterExpression == null
                        ? comparison
                        : Expression.And(filterExpression, comparison);
                }

                // Create the lambda expression with the parameter and the filter expression
                filters = Expression.Lambda<Func<T, bool>>(filterExpression, parameter);
            }
            catch (Exception)
            {
                filters = null;
            }
            return filters;
        }

    }
}
