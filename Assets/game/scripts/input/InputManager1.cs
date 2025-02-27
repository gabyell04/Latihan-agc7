using System;
using UnityEngine;

public class InputManager1 : MonoBehaviour
{
    public Action<Vector2> OnMoveInput;
    public Action<bool> OnSprintInput;
    public Action OnJumpInput;
    public Action OnClimbInput;
    public Action OnCancleClimb;
    // Update is called once per frame
    private void Update()
    {
        CheckMovementInput();
        CheckSprintInput();
        CheckJumpInput();
        CheckCrouchInput();
        CheckPunchInput();
        CheckMainMenuInput();
        CheckCancleInput();
        CheckChangePOVInput();
        CheckGlideInput();
        CheckClimbInput();
        

    }
    private void CheckMovementInput()
    {
        float verticalAxis = Input.GetAxis("Vertical");
        float horizontalAxis = Input.GetAxis("Horizontal");
        Vector2 inputAxis= new Vector2(verticalAxis, horizontalAxis);
        if (OnMoveInput != null )
        {
            OnMoveInput(inputAxis);
        }
    }

    private void CheckSprintInput()
    {
        bool isHoldSprintInput = Input.GetKey(KeyCode.LeftShift);
        Input.GetKey(KeyCode.RightShift);

        if (isHoldSprintInput)
        {
            OnSprintInput(true);
        }
        else
        {
           OnSprintInput(false);
        }
    }


    private void CheckJumpInput()
    {
        bool isPressJumpInput = Input.GetKey(KeyCode.Space);
        if (isPressJumpInput)
        {
            if (OnJumpInput != null)
            {
                OnJumpInput();
            }
        }
    }


    private void CheckCrouchInput()
    {
        bool isPressCrouchInput = Input.GetKey(KeyCode.LeftControl);
        Input.GetKey(KeyCode.RightControl);
        if (isPressCrouchInput)
        {
            Debug.Log("Crouch");
        }
    }


    private void CheckChangePOVInput()
    {
        bool isPressChangePOVInput = Input.GetKey(KeyCode.Q);
        if (isPressChangePOVInput)
        {
            Debug.Log("Change POV");
        }
    }

    private void CheckClimbInput()
    {
        bool isPressClimbInput = Input.GetKey(KeyCode.E);
        if (isPressClimbInput)
        {
            OnClimbInput();
        }
    }

    private void CheckGlideInput()
    {
        bool isPressGlideInput = Input.GetKey(KeyCode.G);
        if (isPressGlideInput)
        {
            Debug.Log("Glide");
        }
    }


    private void CheckCancleInput()
    {
        bool isPressCancleInput = Input.GetKey(KeyCode.C);
        if (isPressCancleInput)
        {
            if (OnCancleClimb!=null)
            {
                OnCancleClimb();
            }
        }
    }

    private void CheckPunchInput()
    {
        bool isPressPunchInput = Input.GetKey(KeyCode.Mouse0);
        if (isPressPunchInput)
        {
            Debug.Log("Punch");
        }
    }


    private void CheckMainMenuInput()
    {
        bool isPressMainMenuInput = Input.GetKey(KeyCode.Escape);
        if (isPressMainMenuInput)
        {
            Debug.Log("Back To Main Menu");
        }
    }

    

}
