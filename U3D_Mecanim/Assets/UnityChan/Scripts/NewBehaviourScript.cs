using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            anim.SetInteger("state",2);
            if(Input.GetKey(KeyCode.F)){
            anim.SetInteger("state",6);
            }else if(Input.GetKeyUp(KeyCode.F)){
            anim.SetInteger("state",2);
            }
        }else if(Input.GetKeyUp(KeyCode.W)){
            anim.SetInteger("state",1);
        }
        else if(Input.GetKey(KeyCode.S)){
            anim.SetInteger("state",3);
        }else if(Input.GetKeyUp(KeyCode.S)){
            anim.SetInteger("state",1);
        }
        else if(Input.GetKey(KeyCode.A)){
            anim.SetInteger("state",4);
            if(Input.GetKey(KeyCode.F)){
            anim.SetInteger("state",7);
            }else if(Input.GetKeyUp(KeyCode.F)){
            anim.SetInteger("state",4);
            }

        }else if(Input.GetKeyUp(KeyCode.A)){
            anim.SetInteger("state",1);
        }
        else if(Input.GetKey(KeyCode.D)){
            anim.SetInteger("state",5);
            if(Input.GetKey(KeyCode.F)){
            anim.SetInteger("state",8);
            }else if(Input.GetKeyUp(KeyCode.F)){
            anim.SetInteger("state",5);
            }
        }else if(Input.GetKeyUp(KeyCode.D)){
            anim.SetInteger("state",1);
        }
        else if(Input.GetKeyDown(KeyCode.J)){
            anim.SetInteger("state",6);
        }else if(Input.GetKeyUp(KeyCode.J)){
            anim.SetInteger("state",1);
        }
    }
}
