using System;

namespace CsReposory
{
    public static class MyClass
    {
        public static string GetUpper(this string ss)
        {
            return ss.ToUpper();
        }
        public static string GetLower(this string ss)
        {
            return ss.ToLower();
        }
    }
}
