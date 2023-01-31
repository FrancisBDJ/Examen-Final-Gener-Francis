using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private float distancia = 2.5f;
    
    [SerializeField] private List<GameObject> objectPrefabs;

    private Transform player;
    // Start is called before the first frame update
    
    public void SpawnObjects()
    {
        
        
        int i;
        for(i=0;i<objectPrefabs.Count;i++)
        {
            player = GameObject.FindWithTag("Player").transform;
            float xPosition = player.transform.position.x + Random.Range(-distancia, distancia);
            float yPosition = player.transform.position.y + Random.Range(-distancia, distancia);
            float zPosition = player.transform.position.z + Random.Range(-distancia, distancia);
            Vector3 position = new Vector3(xPosition,yPosition,zPosition) ;
            
            
            Instantiate(objectPrefabs[i], position, Quaternion.identity);
        }
        
    }
    void Start()
    {
        
        SpawnObjects();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
