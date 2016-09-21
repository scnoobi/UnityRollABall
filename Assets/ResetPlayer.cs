using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour {


    void OnTriggerEnter()
    {
        CheckPointSystem.instance.ResetPlayer();
    }
}
