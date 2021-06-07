using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPickUp : MonoBehaviour
{

    public GameObject[] objects;
    // Start is called before the first frame update
    void Start()
    {
        

        for(int i=0;i< objects.Length;i++)
        {
            int x = Random.Range(-9, 9);
            int z = Random.Range(9, -9);
            Instantiate(objects[i], objects[i].transform.position = new Vector3(x, 0.5f, z), transform.rotation);
            Destroy(objects[i], 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
