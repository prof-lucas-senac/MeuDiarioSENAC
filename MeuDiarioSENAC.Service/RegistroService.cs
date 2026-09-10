public class RegistroService
{
    public void AdicionarRegistro(Registro registro)
    {
        RegistroBusiness registroBusiness = new RegistroBusiness();
        registroBusiness.TituloNaoEstaVazio(registro);

        RegistroDAO registroDAO = new RegistroDAO();
        registroDAO.Inserir(registro);
    }
}