using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);

        other.attachedRigidbody.AddForce (0,0,-1 * 100, ForceMode.Impulse);
        
    }
}
