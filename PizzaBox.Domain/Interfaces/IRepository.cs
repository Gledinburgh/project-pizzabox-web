using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    bool Create(T entry);
    //update
    IEnumerable<T> Read(Func<T, bool> filter);
    T Update();

    //delete
    bool Delete();
  }
}