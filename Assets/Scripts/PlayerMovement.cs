using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private AudioSource obstacleAudioSource;
    
    [SerializeField] private int rotationSpeed = 2;
    [SerializeField] private int moveSpeed = 5;
    
    public void PlayerMove()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(0f,0f , (verticalInput * moveSpeed * Time.deltaTime));
        transform.Translate(movement);
        transform.Rotate(0f, horizontalInput * rotationSpeed, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            obstacleAudioSource = collision.gameObject.GetComponent<AudioSource>();
            obstacleAudioSource.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
}
