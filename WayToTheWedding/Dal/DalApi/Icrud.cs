﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi;

public interface Icrud<T>
{
    List<T> GetAll();
    T Create(T item);
    T Update(int Id, T item);
    T Delete(int id);
}
