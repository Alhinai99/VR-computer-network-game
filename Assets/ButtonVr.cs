using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public InputActionProperty onPressAction;
    public InputActionProperty onReleaseAction;

    private GameObject presser;
    private bool isPressed;

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed && other.CompareTag("Player"))
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPressAction.action.performed += _ => OnPress();
            onPressAction.action.Enable();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == presser && other.CompareTag("Player"))
        {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onReleaseAction.action.performed += _ => OnRelease();
            onReleaseAction.action.Enable();
            isPressed = false;
        }
    }

    private void OnPress()
    {
        Debug.Log("Button pressed.");
        // Add your logic for button press action here
    }

    private void OnRelease()
    {
        Debug.Log("Button released.");
        // Add your logic for button release action here
    }

    public void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
    }

    private void OnDisable()
    {
        onPressAction.action.Disable();
        onReleaseAction.action.Disable();
    }
}
