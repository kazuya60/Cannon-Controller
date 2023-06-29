using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Vector3 startPos;
    [SerializeField]
    private float frequency = 5f;

    [SerializeField]
    private float magnitude = 5f;

    [SerializeField]
    private float offset = 0f;
    // Use this for initialization
    void Start () {
        startPos = transform.position;
    }
   
    // Update is called once per frame
    void Update () {
       transform.position = startPos + transform.forward * Mathf.Sin(Time.time * frequency + offset) * magnitude;

}
}
