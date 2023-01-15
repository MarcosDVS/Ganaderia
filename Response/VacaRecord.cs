namespace Ganaderia.Response;

public class VacaRecord
{
    public int VacaId { get; set; }
    public string Raza { get; set; } = null!;
    public string Color { get; set; } = null!;
    public string Sexo { get; set; } = null!;
    public DateTime Nacimiento { get; set; } = DateTime.Now;
    public int? Peso { get; set; }
    public int Costo { get; set; }
    public string? Registro { get; set; }
    public string? Observacion { get; set; }
}