using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    Animator anim;
    sdfdsf keySpace,keyP,keyK;

    // Start is called before the first frame update
    void Start()
    {
        anim = actor.GetComponent<Animator>();
        keySpace = new PerformJump();
        keyP = new PerformPunch();
        keyK = new PerformKick();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(anim);
        }
        else if(Input.GetKeyDown(KeyCode.P))
        {
            keyP.Execute(anim);
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            keyK.Execute(anim);
        }
    }
}
