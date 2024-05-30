using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IPcheck : MonoBehaviour
{
    [SerializeField] TMP_InputField ip1;
    [SerializeField] TMP_InputField ip2;
    [SerializeField] TMP_InputField ip3;
    [SerializeField] GameObject sameIP;
    [SerializeField] GameObject rangeIP;
    [SerializeField] GameObject connected;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] Color successfulColor = Color.green;
    [SerializeField] Color wrongIPColor = Color.red;
    [SerializeField] AudioSource successAudio;
    [SerializeField] AudioSource wrongAudio;

    public void ipchecker()
    {
        if (ip1.text == ip2.text || ip1.text == ip3.text)
        {
            sameIP.SetActive(true);
            rangeIP.SetActive(false);
            connected.SetActive(false);
            lineRenderer.material.color = wrongIPColor;
            wrongAudio.Play();
        }
        else if (int.Parse(ip1.text) <= 1 || int.Parse(ip1.text) > 254)
        {
            rangeIP.SetActive(true);
            sameIP.SetActive(false);
            connected.SetActive(false);
            lineRenderer.material.color = wrongIPColor;
            wrongAudio.Play();
        }
        else
        {
            rangeIP.SetActive(false);
            sameIP.SetActive(false);
            connected.SetActive(true);
            successAudio.Play();

            lineRenderer.material.color = successfulColor;
        }
    }
}


