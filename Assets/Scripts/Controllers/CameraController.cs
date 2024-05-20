using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float cameraspeed = 4f;
    public GameObject player;

    private void Update()
    {
        Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraspeed * Time.deltaTime, dir.y * cameraspeed * Time.deltaTime, 0);
        this.transform.Translate(moveVector);
    }
}
