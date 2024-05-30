using CodeBase.AssetManagement;
using CodeBase.StaticData;
using UnityEngine;

namespace CodeBase.UI
{
    public class LoadPrefab : MonoBehaviour
    {
        public PrefabKey PrefabKey;
        
        public async void Construct(IAssets assets)
        {
            if (GetPrefabAddress(out var address))
            {
                GameObject prefab = await assets.Load<GameObject>(address);
                Instantiate(prefab, transform);
            }
            else
                Debug.LogError("Такого префаба в Assets Group не существует, проверьте правильность заполнения ключей");
        }

        private bool GetPrefabAddress(out string address) => 
            PrefabAddress.PrefabAddresses.TryGetValue(PrefabKey, out address);
    }
}