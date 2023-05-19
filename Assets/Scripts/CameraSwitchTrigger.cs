using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchTrigger : MonoBehaviour
{
    [SerializeField] private int _selectCamera;

    private CameraManager _camManager;

    void Start()
    {
        _camManager = GameObject.Find("Camera_Manager").GetComponent<CameraManager>();
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _camManager.ResetCams();
            _camManager.SetMasterCam(_selectCamera);
        }
    }




}
