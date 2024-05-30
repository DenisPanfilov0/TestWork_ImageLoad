using System.Collections.Generic;

namespace CodeBase.StaticData
{
        public static class PrefabAddress
        {
            public static readonly Dictionary<PrefabKey, string> PrefabAddresses = new Dictionary<PrefabKey, string>
            {
                { PrefabKey.Blue, "Prefab_1" },
                { PrefabKey.Red, "Prefab_2" },
            };
        }
    
        public enum PrefabKey
        {
            Blue,
            Red,
        }
}