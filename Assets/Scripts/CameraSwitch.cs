using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] private GameObject _virtualcam1;
    [SerializeField] private GameObject _target1;
    [SerializeField] private GameObject _target2;

    private bool _firstTarget;

    private void Start()
    {
        _virtualcam1.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwitchTarget();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CameraZoom();
        }
    }
    private void CameraZoom()
    {
        float _FOV = _virtualcam1.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView -= 20;

        if (_FOV < 20)
        {
            _virtualcam1.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60;
        }
    }
    private void SwitchTarget()
    {
        if (_firstTarget == true)
        {
            _virtualcam1.GetComponent<CinemachineVirtualCamera>().LookAt = _target1.transform;
            _firstTarget = false;
        }
        else
        {
            _virtualcam1.GetComponent<CinemachineVirtualCamera>().LookAt = _target2.transform;
            _firstTarget = true;
        }
    }



}
