using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Transform target;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2.0f;
        target = GameObject.FindWithTag("Target").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, target.transform.position) >= 1)
        {
            transform.LookAt( target.transform.position, Vector3.up );
            transform.position += transform.forward * (speed * Time.deltaTime);
        }
        
    }
}
