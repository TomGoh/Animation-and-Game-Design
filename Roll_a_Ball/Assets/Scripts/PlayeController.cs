using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayeController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject lossTextObject;
    public GameObject winTextObject;
    public GameObject finishObject;


    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private int count;
    private int RightCount;
    private int sum;
    private bool win;
    public  AudioSource CollisionAudio;
    public AudioSource WinAudio;
    public AudioSource LoseAudio;
    public GameObject collision;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        sum = 0;
        RightCount = 0;

        setCountText();
        win = false;
        winTextObject.SetActive(false);
        lossTextObject.SetActive(false);
        finishObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    void setCountText()
    {
        countText.text = "Count:" + count.ToString();
        if (count >= 9)
        {
            winTextObject.SetActive(true);
        }else if (count < 0)
        {
            lossTextObject.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX,0.0f, movementY);
        rb.AddForce(movement*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            sum++;
            other.gameObject.SetActive(false);
            count++;
            RightCount++;
            CollisionAudio.Play();
            GameObject CollisionAnimation=(GameObject)Instantiate(collision, transform.position, Quaternion.identity);
            setCountText();
            if (count == 9)
            {
                WinAudio.Play();
                win = true;
            }
            Destroy(CollisionAnimation, 1.0f);
        }
        else if (other.gameObject.CompareTag("MalPickUp"))
        {
            sum++;
            other.gameObject.SetActive(false);
            count--;
            CollisionAudio.Play();
            GameObject CollisionAnimation = (GameObject)Instantiate(collision, transform.position, Quaternion.identity);
            setCountText();
            if (count <0 )
            {
                LoseAudio.Play();
            }
            Destroy(CollisionAnimation, 1.0f);
        }

        if (sum == 12)
        {
            if (count <9 && !win)
            {
                finishObject.SetActive(true);
                lossTextObject.SetActive(false);
            }
            
        }else if (RightCount == 9)
        {
            if (count < 9 && !win)
            {
                finishObject.SetActive(true);
                lossTextObject.SetActive(false);
            }
        }

    }
}
