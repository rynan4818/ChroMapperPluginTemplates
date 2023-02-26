using UnityEngine;

namespace $safeprojectname$
{
    [Plugin("$projectname$")]
    public class Plugin
    {
        [Init]
        private void Init()
        {
            Debug.Log("$projectname$ Plugin has loaded!");
        }
        [Exit]
        private void Exit()
        {
            Debug.Log("$projectname$ Plugin has closed!");
        }
    }
}
