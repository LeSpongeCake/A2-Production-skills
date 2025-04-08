using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float speed = 2f;
    public float jumpspeed = 15f;
    private InputSystem_Actions _input;
    private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _input = new InputSystem_Actions();
        _input.Player.Enable();
        _input.Player.Jump.performed += Jump_performed;
    }

    private void Jump_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        _rb.AddForce(Vector3.up * 15f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0f, speed * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.G))
        {
            speed = 1f;
        }
        if(Input.GetKey(KeyCode.H))
        {
            jumpspeed = 4f;
        }
    }
}
