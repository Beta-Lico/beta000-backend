namespace Plataforma.Backend_.Models;

public class Profissional
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Nome { get; set; } = string.Empty;
    public string Telefone { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Localizacao { get; set; } = string.Empty;
    public List<string> Servicos { get; set; } = new();
}