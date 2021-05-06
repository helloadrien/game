using CameraPolicy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform Transform;
    private Chapter0PilotController PilotController;

    // Start is called before the first frame update
    void Start()
    {
        Transform = GetComponent<Transform>();
        PilotController = GetComponent<Chapter0PilotController>();
    }

    void LateUpdate()
    {
        var cameraPolicyFactory = new CameraPolicyFactory();

        var cameraPolicy = cameraPolicyFactory.Create(PilotController.PilotPoints);

        cameraPolicy.Update(Transform);
    }
}
