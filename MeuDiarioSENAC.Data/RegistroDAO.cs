using Microsoft.EntityFrameworkCore;
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
        return conexao.Registros
            .AsNoTracking()
            .Include(r => r.Usuario)
            .ToList();
    }

    public Registro? BuscarPorId(int id)
    {
        return conexao.Registros
            .AsNoTracking()
            .Include(r => r.Usuario)
            .FirstOrDefault(r => r.Id == id);
    }
}