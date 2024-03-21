using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Scola
{
  public class ScolaBaseContext : DbContext
  {
    public DbSet<AlunoEntity> Aluno { get; set; }
    public DbSet<AvaliacaoEntity> Avaliacao { get; set; }
    public DbSet<DisciplinaEntity> Disciplina { get; set; }
    public DbSet<EscolaEntity> Escola { get; set; }
    public DbSet<FrequenciaEntity> Frequencia { get; set; }
    public DbSet<MatriculaEntity> Matricula { get; set; }
    public DbSet<ModuloEntity> Modulo { get; set; }
    public DbSet<NotaEntity> Nota { get; set; }
    public DbSet<PeriodoLetivoEntity> PeriodoLetivo { get; set; }
    public DbSet<PessoaEntity> Pessoa { get; set; }
    public DbSet<ProfessorEntity> Professor { get; set; }
    public DbSet<TurmaDisciplinaEntity> TurmaDisciplina { get; set; }
    public DbSet<TurmaEntity> Turma { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<AlunoEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<AvaliacaoEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<DisciplinaEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<EscolaEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<FrequenciaEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<MatriculaEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<ModuloEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<NotaEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<PeriodoLetivoEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<PessoaEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<ProfessorEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<TurmaDisciplinaEntity>().HasKey(r => r.Id);
      modelBuilder.Entity<TurmaEntity>().HasKey(r => r.Id);

      base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      optionsBuilder.UseSqlite(configuration.GetConnectionString("MyConnectionString"));
    }
  }
}
