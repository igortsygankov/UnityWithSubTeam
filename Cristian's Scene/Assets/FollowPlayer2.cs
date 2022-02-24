//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public Transform player;
    public Vector3 offset2;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset2;
    }
}
