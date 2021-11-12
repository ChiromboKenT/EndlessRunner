using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftBoundary = -3f;
    public static float rightBoundary = 3f;
    public float internalLeftBoundary;
    public float internalRightBoundary;
   
    // Update is called once per frame
    void Update()
    {
        internalLeftBoundary = leftBoundary;
        internalRightBoundary = rightBoundary;
    }

    
}
