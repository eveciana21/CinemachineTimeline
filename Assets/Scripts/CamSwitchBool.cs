using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchBool : MonoBehaviour
{
    [SerializeField] private GameObject _3rdPersonCam;
    [SerializeField] private GameObject _orbitalCam;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            _3rdPersonCam.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            _3rdPersonCam.SetActive(true);
        }
    }
}
