using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowTarget : MonoBehaviour
{

    public Transform player1;
    public Transform player2;
    public GameObject textContent;
    public GameObject gameStarter;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - (player1.position + player2.position) / 2;
        transform.position = (player1.position + player2.position) / 2 + offset;
        Destroy(textContent, 2);
        Destroy(gameStarter, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if(player1==null||player2==null)return;
        transform.position = (player1.position + player2.position) / 2 + offset;
        float distance = Vector3.Distance(player1.position, player2.position);
        float size = distance * 0.58f;
        GetComponent<Camera>().orthographicSize = size;
    }
}
