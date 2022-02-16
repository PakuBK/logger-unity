using System.Diagnostics;

namespace Paku.Logger
{
    public static class QLogger
    {
        [Conditional("ENABLE_LOGS")]
        public static void Log(string _msg, string origin)
        {
            UnityEngine.Debug.Log(string.Format("[{0}] {1}", origin, _msg));
        }
        [Conditional("ENABLE_LOGS")]
        public static void LogWarning(string _msg, string origin)
        {
            UnityEngine.Debug.LogWarning(string.Format("[{0}] {1}", origin, _msg));
        }
        [Conditional("ENABLE_LOGS")]
        public static void LogError(string _msg, string origin)
        {
            UnityEngine.Debug.LogError(string.Format("[{0}] {1}", origin, _msg));
        }

    }

}