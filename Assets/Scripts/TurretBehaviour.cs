using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    [SerializeField] private float radi = 4.0f;
    public float rotationSpeed = 25f;

    public GameObject hitGameObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime), Space.World);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, radi))
        {
            if (hit.transform.gameObject.CompareTag("Player"))
            {
                Debug.Log(hit.transform.gameObject.name);
            }
        }
        
    }
}
