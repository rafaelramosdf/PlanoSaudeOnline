namespace PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;

public class PagedQueryResponse<TData>
{
    public PagedQueryResponse(TData items, int currentPage, int perPage, long totalItems)
    {
        Items = items;
        CurrentPage = currentPage;
        PerPage = perPage;
        TotalItems = totalItems;
    }

    public TData? Items { get; set; }
    public int CurrentPage { get; set; } = 1;
    public int PerPage { get; set; } = 10;
    public int Pages => Convert.ToInt32(Math.Ceiling((decimal)TotalItems / (decimal)PerPage));
    public long TotalItems { get; set; }
}
