using PlanoSaudeOnline.Domain._Shared.Base.Handlers.Responses;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.PlanoSaude.Entities;
using PlanoSaudeOnline.Domain.PlanoSaude.Handlers.Responses;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Entities;
using PlanoSaudeOnline.Domain.ValorComercialMensalidade.Handlers.Responses;

public static class ConversorExtension
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

    public static IEnumerable<PlanoSaudeResponse> ConverterParaPlanoSaudeResponse(this IEnumerable<PlanoSaude> data)
    {
        var newList = new List<PlanoSaudeResponse>();
        foreach (var item in data)
            newList.Add(new PlanoSaudeResponse(item));

        return newList;
    }

    public static PagedQueryResponse<IEnumerable<PlanoSaudeResponse>> ConverterParaPlanoSaudeResponse(this PagedQueryResponse<IEnumerable<PlanoSaude>> data)
    {
        return
            new PagedQueryResponse<IEnumerable<PlanoSaudeResponse>>(
                data.Items?.ConverterParaPlanoSaudeResponse() ?? new List<PlanoSaudeResponse>(),
                data.CurrentPage,
                data.PerPage,
                data.TotalItems);
    }

    public static IEnumerable<ValorComercialMensalidadeResponse> ConverterParaValorComercialMensalidadeResponse(this IEnumerable<ValorComercialMensalidade> data)
    {
        var newList = new List<ValorComercialMensalidadeResponse>();
        foreach (var item in data)
            newList.Add(new ValorComercialMensalidadeResponse(item));

        return newList;
    }

    public static PagedQueryResponse<IEnumerable<ValorComercialMensalidadeResponse>> ConverterParaValorComercialMensalidadeResponse(this PagedQueryResponse<IEnumerable<ValorComercialMensalidade>> data)
    {
        return
            new PagedQueryResponse<IEnumerable<ValorComercialMensalidadeResponse>>(
                data.Items?.ConverterParaValorComercialMensalidadeResponse() ?? new List<ValorComercialMensalidadeResponse>(),
                data.CurrentPage,
                data.PerPage,
                data.TotalItems);
    }
}