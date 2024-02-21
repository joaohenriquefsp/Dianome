namespace Dianome.Model.Entidades;

public class Veiculo
{
    int Id { get; set; }

    String Placa { get; set; } = string.Empty;

    String Modelo { get; set; } = string.Empty;

    Decimal CapacidadeDoVeiculo { get; set; }

    int EntregadorId { get; set; }

}