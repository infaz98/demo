﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Interfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync<TId>(TId id);
        Task<List<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
    }
}
