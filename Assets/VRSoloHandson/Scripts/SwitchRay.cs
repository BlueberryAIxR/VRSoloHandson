using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class SwitchRay : MonoBehaviour
{
    [SerializeField] XRRayInteractor xrRayInteractor;
    [SerializeField] InputActionReference inputActionReference;

    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnEnable()
    {
        inputActionReference.action.performed += OnPrimaryButtonClicked;

    }

    private void OnDisable()
    {
        inputActionReference.action.performed -= OnPrimaryButtonClicked;

    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion


    #region XR Callback Methods
    private void OnPrimaryButtonClicked(InputAction.CallbackContext obj)
    {
        if (!xrRayInteractor.enabled)
        {
            xrRayInteractor.enabled = true;
            xrRayInteractor.lineType = XRRayInteractor.LineType.StraightLine;
        }
        else if (xrRayInteractor.lineType == XRRayInteractor.LineType.StraightLine)
        {
            xrRayInteractor.lineType = XRRayInteractor.LineType.ProjectileCurve;
        }
        else if (xrRayInteractor.lineType == XRRayInteractor.LineType.ProjectileCurve)
        {
            xrRayInteractor.enabled = false;
        }
    }


    #endregion


}