using CodeBase.AssetManagement;
using CodeBase.StaticData;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.UI
{
    public class LoadSprite : MonoBehaviour
    {
        public Image Image;
        public SpriteKey SpriteKey;
        
        public async void Construct(IAssets assets)
        {
            if (GetSpriteAddress(out var address))
            {
                Sprite sprite = await assets.Load<Sprite>(address);
                Image.sprite = sprite;
            }
            else
            {
                Debug.LogError("Такого спрайта в Assets Group не существует, проверьте правильность заполнения ключей");
            }
        }

        private bool GetSpriteAddress(out string address)
        {
            return SpriteAddress.SpriteAddresses.TryGetValue(SpriteKey, out address);
        }
    }
}