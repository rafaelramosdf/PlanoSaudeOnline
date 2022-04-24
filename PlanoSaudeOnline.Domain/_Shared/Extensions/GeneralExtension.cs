using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;


public static class GeneralExtension
{
    public static IEnumerable<OperadoraPlanoSaudeResponse> ConverterParaOperadoraPlanoSaudeResponse(this IEnumerable<OperadoraPlanoSaude> data)
    {
        var newList = new List<OperadoraPlanoSaudeResponse>();
        foreach (var item in data)
            newList.Add(new OperadoraPlanoSaudeResponse(item));

        return newList;
    }

    public static PagedQueryResponse<IEnumerable<OperadoraPlanoSaudeResponse>> ConverterParaOperadoraPlanoSaudeResponse(this PagedQueryResponse<IEnumerable<OperadoraPlanoSaude>> data)
    {
        return 
            new PagedQueryResponse<IEnumerable<OperadoraPlanoSaudeResponse>>(
                data.Items?.ConverterParaOperadoraPlanoSaudeResponse() ?? new List<OperadoraPlanoSaudeResponse>(), 
                data.CurrentPage, 
                data.PerPage, 
                data.TotalItems);
    }
}