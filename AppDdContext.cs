using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Tarefa> Tarefas { get; set; }
}
public class Tarefa
{
    public int Id { get; set; }
    public required string Descricao { get; set; }
    public bool Concluida { get; set; }
}