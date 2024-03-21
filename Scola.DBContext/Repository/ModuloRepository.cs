namespace Scola
{
  public class ModuloRepository: ScolaBaseRepository<ModuloEntity>
  {
    public ModuloRepository() : base(new ScolaBaseContext()) { }
  }
}
