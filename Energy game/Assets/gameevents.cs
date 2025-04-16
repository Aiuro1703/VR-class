using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameevents : MonoBehaviour
{
    public static gameevents current;



    private void Awake()
    {
        current = this;
    }

    public event Action eventCradleActive;

    public void setCradleActive()
    {
        if(eventCradleActive != null)
        {
            eventCradleActive();
        }
    }


}
