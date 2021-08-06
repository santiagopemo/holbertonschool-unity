using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    public Transform cam;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    public PauseMenu pauseMenu;

    public Animator animator;
    public bool isFalling = false;

    public InputActionReference movement;
    public InputActionReference jump;

    public bool playerWon = false;

    private void OnEnable()
    {
        movement.action.Enable();
        jump.action.Enable();
    }

    private void OnDisable()
    {
        movement.action.Disable();
        jump.action.Disable();
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        initialPosition.y += 50;
        pauseMenu = GetComponent<PauseMenu>();
        animator = transform.Find("ty").GetComponent<Animator>();
    }
    void Update() {
        if (pauseMenu.paused || playerWon)
            return;
        float xDisplacement = movement.action.ReadValue<Vector2>().x;
        float zDisplacement = movement.action.ReadValue<Vector2>().y;
        animator.SetBool("isGrounded", controller.isGrounded);
        if (isFalling)
            xDisplacement = zDisplacement = 0.0f;
        
        if (controller.isGrounded) 
        {
            animator.SetBool("isFalling", false);
            moveDirection = new Vector3(xDisplacement * speed, 0, zDisplacement * speed);
            if (jump.action.triggered)
            {
                moveDirection.y = jumpSpeed;
                animator.SetTrigger("isJumping");
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", false);
            }                          
        }
        else
        {
            moveDirection = new Vector3(xDisplacement * speed, moveDirection.y, zDisplacement * speed);
        }
        moveDirection.y += gravity * Time.deltaTime;
        if (moveDirection.x != 0.0f || moveDirection.z != 0.0f)
        {
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            moveDir.y = moveDirection.y;
            moveDir.x *= speed;
            moveDir.z *= speed;
            controller.Move(moveDir * Time.deltaTime);
            if (controller.isGrounded)
            {
                animator.SetBool("isRunning", true);
                animator.SetBool("isIdling", false);
            }                
            else
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", false);
            }                
        }
        else
        {
            controller.Move(moveDirection * Time.deltaTime);            
            if (controller.isGrounded)
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", true);
            }                
            else
            {
                animator.SetBool("isRunning", false);
                animator.SetBool("isIdling", false);
            }
        }
        if (transform.position.y < -30)
        {
            transform.position = initialPosition;
            transform.rotation = initialRotation;
            animator.SetBool("isFalling", true);
        }
    }
}
