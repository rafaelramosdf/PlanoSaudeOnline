using Flunt.Validations;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities.Validations.Specifications;

public class CamposObrigatoriosSpecification : Contract<OperadoraPlanoSaude>
{
    public CamposObrigatoriosSpecification(OperadoraPlanoSaude operadoraPlanoSaude)
    {
        Requires()
            .IsNotNullOrEmpty(operadoraPlanoSaude.Cnpj, nameof(operadoraPlanoSaude.Cnpj), "Informe o campo Cnpj");
    }
}
