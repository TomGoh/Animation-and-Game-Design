using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellEffect : MonoBehaviour
{

    public GameObject shellExplosion;

    public AudioClip shellExplosionAudio;

    
  
    public void OnTriggerEnter(Collider collider)
    {
        AudioSource.PlayClipAtPoint(shellExplosionAudio,transform.position);
        GameObject.Instantiate(shellExplosion, transform.position, transform.rotation);
        GameObject.Destroy(this.gameObject);
        print("Destoried...");

        if (collider.tag == "Tank")
        {
            collider.SendMessage("TankDamaged");
        }
    }
}