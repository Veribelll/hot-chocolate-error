using GreenDonut.Data;
using HotChocolate.Types.Pagination;

namespace GraphQLError.Types;

[QueryType]
public static class Query
{
    [UsePaging]
    [UseFiltering]
    [UseSorting]
    public static Connection<Book> GetBooks(PagingArguments pagingArguments, QueryContext<Book> queryContext)
        => Connection.Empty<Book>();
}