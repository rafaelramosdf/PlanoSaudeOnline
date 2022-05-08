using System.ComponentModel;

namespace PlanoSaudeOnline.Web.Site.Models.Enumerations;

public enum FaixaEtariaEnum
{
    [Description("00 (zero) a 18 (dezoito) anos")]
    DeZeroAteDezoitoAnos = 1,

    [Description("19 (dezenove) a 23 (vinte e três) anos")]
    DeDezenoveAteVinteETresAnos = 2,

    [Description("24 (vinte e quatro) a 28 (vinte e oito) anos")]
    DeVinteEQuatroAteVinteEOitoAnos = 3,

    [Description("29 (vinte e nove) a 33 (trinta e três) anos")]
    DeVinteENoveAteTrintaETresAnos = 4,

    [Description("34 (trinta e quatro) a 38 (trinta e oito) anos")]
    DeTrintaEQuatroAteTrintaEOitoAnos = 5,

    [Description("39 (trinta e nove) a 43 (quarenta e três) anos")]
    DeTrintaENoveAteQuarentaETresAnos = 6,

    [Description("44 (quarenta e quatro) a 48 (quarenta e oito) anos")]
    DeQuarentaEQuatroAteQuarentaEOitoAnos = 7,

    [Description("49 (quarenta e nove) a 53 (cinquenta e três) anos")]
    DeQuarentaENoveAteCinquentaETresAnos = 8,

    [Description("54 (cinquenta e quatro) a 58 (cinquenta e oito) anos")]
    DeCinquentaEQuatroAteCinquentaEOitoAnos = 9,

    [Description("59 (cinquenta e nove) anos ou mais")]
    DeCinquentaENoveAnosOuMais = 10
}
