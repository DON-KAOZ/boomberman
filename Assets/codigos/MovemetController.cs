using UnityEngine;

public class MovemetController : MonoBehaviour
{
    inputmanager inputmanager;
    CharacterController characterController;
    [SerializeField] float speed;
    void Start()
    {
        inputmanager = GetComponent<inputmanager>();
        characterController = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        if (inputmanager.moveDir.magnitude != 0)
        {
            transform.forward = new Vector3(inputmanager.moveDir.x, 0, inputmanager.moveDir.y);

            characterController.Move(transform.forward * speed * Time.deltaTime);
        }
    }
}
