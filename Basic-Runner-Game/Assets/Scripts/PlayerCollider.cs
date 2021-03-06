using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Enemy")
        {
            Destroy(other.gameObject);
        }

        if (other.tag=="Wall")
        {
            Destroy(gameObject);
        }

        if (other.tag=="EndGame")
        {
            Destroy(gameObject);
        }
    }
}
