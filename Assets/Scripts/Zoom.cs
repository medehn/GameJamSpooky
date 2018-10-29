using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView--;
        }
        
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView++;
        }


    }
}