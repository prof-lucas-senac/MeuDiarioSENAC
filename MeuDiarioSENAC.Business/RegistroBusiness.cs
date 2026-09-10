public class RegistroBusiness
{
    public void TituloNaoEstaVazio(Registro registro)
    {
        if (string.IsNullOrWhiteSpace(registro.Titulo))
        {
            throw new ArgumentException("O título não pode estar vazio.");
        }
    }
}