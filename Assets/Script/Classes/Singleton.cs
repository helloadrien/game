using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static bool shuttingDown = false;
    private static object oLock = new object();
    private static T oInstance;

    public static T Instance
    {
        get
        {
            if (shuttingDown)
            {
                return null;
            }

            lock (oLock)
            {
                if (oInstance == null)
                {
                    oInstance = (T)FindObjectOfType(typeof(T));

                    if (oInstance == null)
                    {
                        var singletonObject = new GameObject();

                        oInstance = singletonObject.AddComponent<T>();

                        singletonObject.name = typeof(T).ToString() + "(Singleton)";

                        DontDestroyOnLoad(singletonObject);
                    }
                }
            }

            return oInstance;
        }
    }

    private void OnApplicationQuit()
    {
        shuttingDown = true;
    }

    private void OnDestroy()
    {
        shuttingDown = true;
    }
}
