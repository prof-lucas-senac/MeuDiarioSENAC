public class RegistroService
{
    public void AdicionarRegistro(Registro registro)
    {
        RegistroBusiness registroBusiness = new RegistroBusiness();
        registroBusiness.TituloNaoEstaVazio(registro);

        RegistroDAO registroDAO = new RegistroDAO();
        registroDAO.Inserir(registro);
    }

    public List<Registro> ListarRegistros()
    {
        RegistroDAO registroDAO = new RegistroDAO();
        return registroDAO.ListarTodos();
    }
}