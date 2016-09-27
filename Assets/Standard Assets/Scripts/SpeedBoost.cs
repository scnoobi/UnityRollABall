using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {

    public float force = 50;

    private AudioSource parentAudioSource;

    void Start()
    {
        parentAudioSource = transform.parent.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        var transformRight = transform.right;
        var otherRbody = other.GetComponent<Rigidbody>();
        
        if (otherRbody && otherRbody.CompareTag("Player"))
        {
            otherRbody.AddForce(transformRight * force, ForceMode.Impulse);
            parentAudioSource.Play();
        }
    }
}
