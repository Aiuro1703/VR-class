using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class Hand_Animator : MonoBehaviour
{
    [SerializeField] private NearFarInteractor nearFarInteractor;
    [SerializeField] private SkinnedMeshRenderer HandMesh;

    private void Awake()
    {
        nearFarInteractor.selectEntered.AddListener(OnGrab);
        nearFarInteractor.selectExited.AddListener(OnRelease);
    }

    private void OnGrab(SelectEnterEventArgs arg0)
    {
        Debug.Log("selected");
        HandMesh.enabled = false;
    }

    private void OnRelease(SelectExitEventArgs args)
    {
        HandMesh.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
