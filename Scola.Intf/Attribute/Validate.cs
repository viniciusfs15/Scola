using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scola
{
  [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
  sealed class Validate : Attribute
  {
    public bool HaveDefault { get; }

    public object? Default { get; }

    public Validate() { }

    public Validate(object valueDefault)
    {
      Default = valueDefault;
      HaveDefault = true;
    }
  }

  [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
  sealed class CanUpdate : Attribute 
  {
    public bool Value { get; }
    public CanUpdate() 
    { 
      Value = true;
    }
  }
}
