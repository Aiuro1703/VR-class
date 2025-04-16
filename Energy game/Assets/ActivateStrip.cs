using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStrip : MonoBehaviour
{
    [SerializeField] GameObject ActiveStrip;

    private void Start()
    {
        ActiveStrip.SetActive(false);
        gameevents.current.eventCradleActive += Activate;
    }

    private void Activate()
    {
        ActiveStrip.SetActive(true);
    }
}
