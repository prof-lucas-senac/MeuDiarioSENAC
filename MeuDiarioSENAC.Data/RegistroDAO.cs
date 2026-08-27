using MySql.Data.MySqlClient;

public class RegistroDAO
{
    private MeuDiarioSENACContext conexao = new MeuDiarioSENACContext();

    public void Inserir(Registro registro)
    {
        conexao.Registros.Add(registro);
        conexao.SaveChanges();
    }

    public List<Registro> ListarTodos()
    {
        return null;
    }

    public Registro? BuscarPorId(int id)
    {
        return null;
    }
}