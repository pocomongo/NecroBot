using System;
using System.ComponentModel;
using System.Reflection;

namespace Necrui
{
    public static class LocalizedHelper
    {
        public static string Get(Type ressourceType, string key) => ressourceType
            ?.GetProperty(key, BindingFlags.NonPublic | BindingFlags.Static)
            ?.GetValue(null, null) as string ?? key;
    }

    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly string _key;
        private readonly Type _ressourceType;

        public LocalizedDescriptionAttribute(string key, Type ressourceType)
        {
            _key = key;
            _ressourceType = ressourceType;
        }

        public override string Description => LocalizedHelper.Get(_ressourceType, _key);

    }

    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        private readonly string _key;
        private readonly Type _ressourceType;
        public LocalizedDisplayNameAttribute(string key, Type ressourceType)
        {
            _key = key;
            _ressourceType = ressourceType;
        }

        public override string DisplayName => $"{LocalizedHelper.Get(_ressourceType, _key)} ({_key})";
    }
}