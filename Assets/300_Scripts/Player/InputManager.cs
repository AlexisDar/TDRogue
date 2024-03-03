using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public PlayerInput playerInput;

    private InputAction move;
    public Vector2 moveValue;
    private InputAction mouse;
    public Vector3 mousePos;

    private InputAction attack;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        move = playerInput.actions["Move"];
        mouse = playerInput.actions["MousePos"];
        attack = playerInput.actions["Attack"];
    }

    private void OnEnable()
    {
        attack.performed += _ => InputAttack();
        attack.canceled += _ => InputStopAttack();
    }

    private void OnDisable()
    {
        attack.performed -= _ => InputAttack();
        attack.canceled -= _ => InputStopAttack();
    }


    public void Update()
    {
        mousePos = Mouse.current.position.ReadValue(); 
        moveValue  = move.ReadValue<Vector2>();
    }

    public void InputAttack()
    {
        PlayerBehavior.Instance.isShooting = true;
        PlayerBehavior.Instance.Shoot();
    }
    public void InputStopAttack()
    {
        PlayerBehavior.Instance.isShooting = false;
    }
}
