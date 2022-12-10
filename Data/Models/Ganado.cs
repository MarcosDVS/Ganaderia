
namespace Ganaderia.Data.Models;

public class Vaca
{
    public int VacaId { get; set; }
    public string Raza { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string Sexo { get; set; } = null!;
    public DateTime Nacimiento { get; set; } = DateTime.Now;
    public int? Peso { get; set; }
    public int Costo { get; set; }
    public string? Observacion { get; set; }
    public int PadreId { get; set; }
    public string RazaPadre { get; set; } = null!;
    public string? ColorPadre { get; set; }
    public string? RegistroPadre { get; set; }
    public int MadreId { get; set; }
    public string RazaMadre { get; set; } = null!;
    public string? ColorMadre { get; set; }
    public string? RegistroMadre { get; set; }
}