using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject ActiveStrip;

    // Start is called before the first frame update
    void Start()
    {
        ActiveStrip.SetActive(false);
        gameevents.current.eventCradleActive += OpenGate;

    }
    private void OpenGate()
    {
        ActiveStrip.SetActive(true);
        animator.SetBool("open", true);
    }
    private void CloseGate()
    {
        animator.SetBool("open", false);
    }
}
