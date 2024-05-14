using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

public class NewBehaviourScript : MonoBehaviour
{
    public int targetFrameRate = 30;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = targetFrameRate;
    }

 
}
