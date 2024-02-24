using System.Linq.Expressions;

namespace Shop.Helpers.FilteringAndPagination
{
    public class CustomExpressionSorting<T> where T : class
    {
        public static IQueryable<T> AddSorting (IQueryable<T> query, List<ColumnSorting> columnSorting, string className)
        {
            Expression<Func<T, string>> sorting = null;
            var isFirstSort = true;

            try
            {
                var parameter = Expression.Parameter(typeof(T), className);

                foreach (var column in columnSorting)
                {

                    var property = Expression.Property(parameter, column.id);

                    // Создаем лямбда-выражение (p => p.Age) или (p => p.Name)
                    var lambda = Expression.Lambda(property, parameter);

                    var methodName = "OrderBy";

                    if (isFirstSort)
                    {
                        methodName = column.desc ? "OrderByDescending" : "OrderBy";
                        isFirstSort = false;
                    }
                    else
                    {
                        methodName = column.desc ? "ThenByDescending" : "ThenBy";
                    }

                    var orderByMethod = typeof(Queryable).GetMethods()
                        .Single(method => method.Name == methodName && method.GetParameters().Length == 2)
                        .MakeGenericMethod(typeof(T), property.Type);

                    query = (IQueryable<T>)orderByMethod.Invoke(null, new object[] { query, lambda });

                }

            }
            catch (Exception)
            {

            }


            return query;
        }

        //public static Expression<Func<T, bool>> CustomSorting(List<ColumnSorting> columnSorting, string className)
        //{
        //    Expression<Func<T, bool>> filters = null;

        //    try
        //    {
        //        // Create the parameter expression for the input data
        //        var parameter = Expression.Parameter(typeof(T), className);

        //        foreach (var item in columnSorting)
        //        {
        //        }

        //    }
        //    catch (Exception)
        //    {

        //    }
        //}
    }
}
