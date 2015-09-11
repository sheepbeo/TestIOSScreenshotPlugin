using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
#if UNITY_IPHONE 
  [DllImport("__Internal")]
 extern static private void _log(string message);
#endif

    public Text DebugText;

    void OnStart()
    {
#if UNITY_IPHONE
        _log (string.Format ("{0}", "Sample Message"));
        DebugText.text = "log called";
#endif
        DebugText.text = "log called outside";
    }

}
