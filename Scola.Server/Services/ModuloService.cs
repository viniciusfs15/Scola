namespace Scola
{
  public class ModuloService : ScolaBaseService<ModuloEntity>
  {
    public ModuloService() : base(new ScolaBaseContext()) { }

    protected override bool BeforeAdd(ModuloEntity entity, string message)
    {
      return EscolaExists(entity.EscolaId);
    }
  }
}
