namespace Dianome.Model.Entidades;

public class Entregador
{
    public int Id { get; set; }

    public String Nome { get; set; } = string.Empty;

    public String Cpf { get; set; } = string.Empty;

    public Veiculo? Veiculo { get; set; }


}


