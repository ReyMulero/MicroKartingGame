using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera InitialCam;
    [SerializeField] CinemachineVirtualCamera ChangeCam;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChangeCam.Priority = 1;
            InitialCam.Priority = 0;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChangeCam.Priority = 0;
            InitialCam.Priority = 1;
        }
    }
}