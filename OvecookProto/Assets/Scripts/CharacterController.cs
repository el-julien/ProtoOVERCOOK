using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private GameManager m_GameManager;

    [Space]
    [Header("turn")]
    [SerializeField] private float turnShmoothTime = 0.1f;
    [SerializeField] private float turnShmoothVelocity;

    [Space]
    [Header("Player Component")]
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Camera cam;

    [Space]
    [Header("Environment Check Properties")]
    [Tooltip("Position of the gameObject who check if the player touch the ground")]
    public Transform groundCheck;

    [Tooltip("the layer of the ground")]
    public LayerMask groundMask;

    [Tooltip("how far the player can check beside his feet")]
    [SerializeField] private float groundDistance;

    [Tooltip("Boolean variable how indicate if the player touch the ground or not")]
    [SerializeField] private bool isGrounded;

    [Space]
    [Header("Movement Variable")]
    [SerializeField] private Vector3 velocity;
    [SerializeField] private float speedMouvement;
    [SerializeField] private float m_JumpPower = 5f;
    [SerializeField] private float gravity = -9.81f;

    [Space]
    [Header("Interact")]
    [SerializeField] GameObject interactGO;
    [SerializeField] Transform interactTransform;
    [SerializeField] Vector3 castGizmoCube;
    [SerializeField] float castRadius;
    [SerializeField] LayerMask interactLayer;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        characterController = GetComponent<CharacterController>();
        groundCheck = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
