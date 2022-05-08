using System.ComponentModel;

namespace PlanoSaudeOnline.Domain._Shared.Enumerations;

public enum SegmentoAssistencialEnum
{
    [Description("")]
    Indefinido,

    [Description("Ambulatorial")]
    Ambulatorial,

    [Description("Ambulatorial + Hospitalar com obstetrícia")]
    AmbulatorialHospitalarComObstetricia,

    [Description("Ambulatorial + Hospitalar com obstetrícia + Odontológico")]
    AmbulatorialHospitalarComObstetriciaOdontologico,

    [Description("Ambulatorial + Hospitalar sem obstetrícia")]
    AmbulatorialHospitalarSemObstetricia,

    [Description("Ambulatorial + Hospitalar sem obstetrícia + Odontológico")]
    AmbulatorialHospitalarSemObstetriciaOdontologico,

    [Description("Ambulatorial + Odontológico")]
    AmbulatorialOdontologico,

    [Description("Hosp c/ obstetrícia + Hosp s/ obstetrícia")]
    HospitalarComObstetriciaMaisHospitalarSemObstetricia,

    [Description("Hosp c/s  Obstetrícia + Odont")]
    HospitalarComOuSemObstetriciaMaisOdontologico,

    [Description("Hospitalar com obstetrícia")]
    HospitalarComObstetricia,

    [Description("Hospitalar sem obstetrícia")]
    HospitalarSemObstetricia,

    [Description("Hospitalar sem obstetrícia + Odontológico")]
    HospitalarSemObstetriciaOdontologico,

    [Description("Odontológico")]
    Odontologico
}
