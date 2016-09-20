using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {

    public float force = 50;

    void OnTriggerEnter(Collider other)
    {
        var transformRight = transform.right;
        var otherRbody = other.GetComponent<Rigidbody>();
        otherRbody.AddForce(transformRight * force, ForceMode.Impulse);
        Debug.Log(transformRight);
    }
}
