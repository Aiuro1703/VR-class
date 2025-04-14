using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        OpenGate();
    }

    // Update is called once per frame
    void Update()
    {

    }




    private void OpenGate()
    {
        animator.SetBool("open", true);
    }
    private void CloseGate()
    {
        animator.SetBool("open", false);
    }
}
