using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingCamera : MonoBehaviour
{
    public Transform Player;

    private Vector3 offsetCamera;

    [Range(0.01f,1.0f)]
    public float SmootchFactor = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        offsetCamera = transform.position - Player.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = Player.position + offsetCamera;

        transform.position = Vector3.Slerp(transform.position, newPos, SmootchFactor);
    }
}
