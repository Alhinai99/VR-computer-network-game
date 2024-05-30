using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hand_pinch_grip: MonoBehaviour
{
    public InputActionProperty PinchAnimationActtion;
    public InputActionProperty GripAnimationAction;

    public Animator handAnimator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = PinchAnimationActtion.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float GripValue = GripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip" , GripValue);

        Debug.Log(GripValue);



    }
}
