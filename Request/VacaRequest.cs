using System.ComponentModel.DataAnnotations;

namespace Ganaderia.Request;

public class VacaRequest
{
    public VacaRequest()
    {

    }
    public VacaRequest(string raza, string color, string sexo, DateTime nacimiento, int peso, int costo, 
    string observacion)
    {
        Raza=raza;
        Color=color;
        Sexo=sexo;
        Nacimiento=nacimiento;
        Peso=peso;
        Costo=costo;
        Observacion=observacion;
    }
    [Required(ErrorMessage = "La Raza del animal es obligatorio.!"), MaxLength(30)]
    public string Raza { get; set; } = null!;

    [Required(ErrorMessage = "El color del animal es obligatorio.!"),MaxLength(30)]
    public string Color { get; set; } = null!;

    [Required(ErrorMessage = "El sexo del animal es obligatorio.!"),MaxLength(30)]
    public string Sexo { get; set; } = null!;
    [Required(ErrorMessage = "La fecha de nacimiento del animal es obligatorio.!")]
    public DateTime Nacimiento { get; set; } = DateTime.Now;
    public int? Peso { get; set; }
    [Required(ErrorMessage = "El costo del animal es obligatorio.!"),MinLength(5),MaxLength(7)]
    public int Costo { get; set; }
    public string? Registro { get; set; }
    public string? Observacion { get; set; }
   }