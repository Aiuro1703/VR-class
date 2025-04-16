using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cradle_trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cradleBall")
        {
            gameevents.current.setCradleActive();
        }
    }
}
