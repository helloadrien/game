using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter0PilotController : MonoBehaviour
{
    public Chapter0PilotPoints PilotPoints;

    // Start is called before the first frame update
    void Start()
    {
        PilotPoints = Chapter0PilotPoints.LiuKeng_Appear;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum Chapter0PilotPoints : uint
{
    LiuKeng_Appear = 0
}