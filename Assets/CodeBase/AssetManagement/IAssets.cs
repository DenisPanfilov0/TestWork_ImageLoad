using System.Threading.Tasks;
using CodeBase.Infrastructure.States;

namespace CodeBase.AssetManagement
{
    public interface IAssets : IService
    {
        Task<T> Load<T>(string address) where T : class;
        void CleanUp();
        void Initialize();
    }
}