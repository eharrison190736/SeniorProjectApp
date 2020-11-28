using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeniorProjectApp.Services
{
    public interface IADataStore<T>
    {
      
        Task<bool> AddAnswerAsync(T Answer);
        Task<bool> UpdateItemAsync(T Answer);
        Task<bool> DeleteItemAsync(string Answer);
        Task<T> GetItemAsync(double count);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}