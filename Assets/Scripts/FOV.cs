using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FOV : MonoBehaviour
{
    private CinemachineVirtualCamera _cam;
   
    void Start()
    {
        _cam = GetComponent<CinemachineVirtualCamera>();
        _cam.m_Lens.FieldOfView = 30;
    }

    void Update()
    {
        
    }
}
