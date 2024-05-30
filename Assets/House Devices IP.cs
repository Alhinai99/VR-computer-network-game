using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HouseDevicesIP : MonoBehaviour
{
    [SerializeField] TMP_InputField ip1;
    [SerializeField] TMP_InputField ip2;
    [SerializeField] TMP_InputField ip3;
    [SerializeField] TMP_InputField ip4;
    [SerializeField] TMP_InputField ip5;
    [SerializeField] TMP_InputField ip6;
    [SerializeField] GameObject sameIP;
    [SerializeField] GameObject rangeIP;
    [SerializeField] GameObject connected;
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] Color successfulColor = Color.green;
    [SerializeField] Color wrongIPColor = Color.red;
    [SerializeField] GameObject MenuConnected;
    [SerializeField] GameObject MenuError;
    [SerializeField] GameObject Notconnected;
    public void ipchecker()
    {
        if (ip1.text == ip2.text || ip1.text == ip3.text || ip1.text == ip4.text || ip1.text == ip5.text || ip1.text == ip6.text)
        {
            sameIP.SetActive(true);
            rangeIP.SetActive(false);
            connected.SetActive(false);
            lineRenderer.material.color = wrongIPColor;
            MenuError.SetActive(true);
            Notconnected.SetActive(false);
            MenuConnected.SetActive(false);
        }
        else if (int.Parse(ip1.text) <= 1 || int.Parse(ip1.text) > 254)
        {
            rangeIP.SetActive(true);
            sameIP.SetActive(false);
            connected.SetActive(false);
            MenuError.SetActive(true);
            Notconnected.SetActive(false);
            MenuConnected.SetActive(false);
            lineRenderer.material.color = wrongIPColor;

        }
        else
        {
            rangeIP.SetActive(false);
            sameIP.SetActive(false);
            connected.SetActive(true);
            MenuError.SetActive(false);
            Notconnected.SetActive(false);
            MenuConnected.SetActive(true);

            lineRenderer.material.color = successfulColor;

        }
    }
}
