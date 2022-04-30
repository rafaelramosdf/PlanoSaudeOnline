namespace PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;

public class PagedQueryResponse<TData>
{
    public PagedQueryResponse(TData items, int currentPage, int perPage, bool hasNextPage)
    {
        Items = items;
        CurrentPage = currentPage;
        PerPage = perPage;
        HasNextPage = hasNextPage;
    }

    public TData? Items { get; set; }
    public int CurrentPage { get; set; } = 1;
    public int PerPage { get; set; } = 10;
    public bool HasNextPage { get; set; } = false;
}
