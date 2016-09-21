using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour {

    public int resetNumber;


    void OnTriggerEnter( Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CheckPointSystem.instance.SetResetPoint(resetNumber);
        }
    }
}
