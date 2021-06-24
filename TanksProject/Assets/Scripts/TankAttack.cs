using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {

    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float speed = 10.0f;
    public AudioClip shotAudio;

    private Transform firePositon;
    
    // Start is called before the first frame update
    void Start() {
        firePositon = transform.Find("FirePosition");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(fireKey)) {
            AudioSource.PlayClipAtPoint(shotAudio,transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab, firePositon.position, firePositon.rotation)as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * speed;
        }
    }
}
