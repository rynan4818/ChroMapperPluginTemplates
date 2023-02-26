using HarmonyLib;
using System.Reflection;
using UnityEngine;

namespace $safeprojectname$
{
    [Plugin("$projectname$")]
    public class Plugin
    {
        public static Harmony _harmony;
        public const string HARMONY_ID = "com.github.username.$projectname$";
        [Init]
        private void Init()
        {
            _harmony = new Harmony(HARMONY_ID);
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
            Debug.Log("$projectname$ Plugin has loaded!");
        }
        [Exit]
        private void Exit()
        {
            _harmony.UnpatchAll(HARMONY_ID);
            Debug.Log("$projectname$ Plugin has closed!");
        }
    }
}
