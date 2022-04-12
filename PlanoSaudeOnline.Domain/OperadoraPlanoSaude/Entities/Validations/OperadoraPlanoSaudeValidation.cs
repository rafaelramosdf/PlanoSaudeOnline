using Flunt.Notifications;
using PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities.Validations.Specifications;

namespace PlanoSaudeOnline.Domain.OperadoraPlanoSaude.Entities.Validations;

public class OperadoraPlanoSaudeValidation : Notifiable<Notification>
{
    public OperadoraPlanoSaudeValidation(OperadoraPlanoSaude operadoraPlanoSaude)
    {
        AddNotifications(new CamposObrigatoriosSpecification(operadoraPlanoSaude));
    }
}
