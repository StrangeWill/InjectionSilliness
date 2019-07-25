
using System;

namespace InjectionSilliness.App
{
    public class Implementation : IThing1, IThing2
    {
        public Guid NewGuid { get; } = Guid.NewGuid();

        public string Shared()
        {
            return NewGuid.ToString();
        }

        public string Thing1()
        {
            return "Thing1";
        }

        public string Thing2()
        {
            return "Thing2";
        }
    }
}