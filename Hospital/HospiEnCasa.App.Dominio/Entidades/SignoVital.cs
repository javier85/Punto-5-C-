using System;

namespace HospiEnCasa.App.Dominio
{
    public class SignoVital 
    {
        public int Id { get; set; }
        public DateTime FechaHora  { get; set; }
        public float Valor {get;set;}
        public TipoSigno Signo { get; set; }
        public Paciente Paciente {get; set;}
    }
}
//dotnet new page -n “Create”-na HospiEnCasa.App.Frontend.Pages -o .\Pages\Saludos\
