using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeCollision : MonoBehaviour
{
    public GameObject woodParticlePrefab;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TriggerCut")
        {
            Debug.Log("hitting tree");

            // spawn particles at collision's position
            Vector2 linePos = collision.transform.position;

            GameObject woodParticleObject = Instantiate(woodParticlePrefab);
            woodParticleObject.transform.position = transform.position;
        }
    }
}
