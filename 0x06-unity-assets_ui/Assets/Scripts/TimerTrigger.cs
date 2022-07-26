using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    // Detects when the player exit the TimeTrigger object
    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            if(other.GetComponent<Timer>().enabled == false)
                other.GetComponent<Timer>().enabled = true;
        }
    }
}
