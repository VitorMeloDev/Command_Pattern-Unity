using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    public Stack<Command> events;

    Animator anim;
    Command keySpace,keyP,keyK,keyUpArrow;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = actor.GetComponent<Animator>();
        keySpace = new PerformJump();
        keyP = new PerformPunch();
        keyK = new PerformKick();
        keyUpArrow = new MoveForward();
        Camera.main.GetComponent<CameraFollow360>().player = actor.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(anim);
            events.Push(keySpace);
        }
        else if(Input.GetKeyDown(KeyCode.P))
        {
            keyP.Execute(anim);
            events.Push(keyP);
        }
        else if(Input.GetKeyDown(KeyCode.K))
        {
            keyK.Execute(anim);
            events.Push(keyK);
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            keyUpArrow.Execute(anim);
            events.Push(keyUpArrow);
        }
    }
}
