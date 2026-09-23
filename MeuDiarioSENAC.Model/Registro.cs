public class Registro
{
    public int Id { get; set; }

    public string Titulo { get; set; } = "";

    public DateTime DataRegistro { get; set; }
    public string Conteudo { get; set; } = "";
    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
}