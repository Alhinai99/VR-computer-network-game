using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class Telport_Active : MonoBehaviour
{
    public GameObject leftTelport;
    public GameObject rightTelport;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;

    //public XRRayInteractor leftRay;
    //public XRRayInteractor rightRay;

    // Update is called once per frame
    void Update()
    {
        //bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNorma, out int leftNumber, out bool leftvalid);

        leftTelport.SetActive( leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1f);

        //bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNorma, out int rightNumber, out bool rightvalid);

        rightTelport.SetActive( rightCancel.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.0f);
    }
}
