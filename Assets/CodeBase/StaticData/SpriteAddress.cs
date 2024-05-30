using System.Collections.Generic;

namespace CodeBase.StaticData
{
    public static class SpriteAddress
    {
        public static readonly Dictionary<SpriteKey, string> SpriteAddresses = new Dictionary<SpriteKey, string>
        {
            { SpriteKey.Girl, "Sprite_1" },
            { SpriteKey.Man, "Sprite_2" },
        };
    }
    
    public enum SpriteKey
    {
        Girl,
        Man,
    }
}