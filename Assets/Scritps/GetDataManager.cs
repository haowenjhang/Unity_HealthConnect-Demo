using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetDataManager : MonoBehaviour
{
    public Text Log;

    public void CheckPermissions()
    {
        using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                jo.Call("checkPermissionsAndRun");
            }
        }

#if UNITY_EDITOR || _IOS

        Log.text = "Not Support This Device ! ";
#endif
    }


    public void GetData()
    {
        using (AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            using (AndroidJavaObject jo = jc.GetStatic<AndroidJavaObject>("currentActivity"))
            {
                jo.Call("getWeight");
            }
        }

#if UNITY_EDITOR || _IOS

        Log.text = "Not Support This Device ! ";
#endif

    }


    public void GetDataInfo(string str)
    {
        Log.text = str;
    }


}
