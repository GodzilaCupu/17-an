using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformAttach : MonoBehaviour
{
    public GameObject Player1, player2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player1 || other.gameObject == player2)
        {
            Player1.transform.parent = transform;
            player2.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player1 || other.gameObject == player2)
        {
            Player1.transform.parent = null;
            player2.transform.parent = null;
        }
    }
}

