using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform player;

    private void FixedUpdate()
    {
        Vector3 offset = new Vector3(0f, 0.34f, -11f);
        transform.position = player.position + offset;
    }
}
