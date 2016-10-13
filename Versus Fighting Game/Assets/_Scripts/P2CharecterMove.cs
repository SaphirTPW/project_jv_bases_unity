using UnityEngine;
using System.Collections;

public class P2CharecterMove : MonoBehaviour {
    [SerializeField]

    float Speed = 10.0f;

    [SerializeField]

    float jumpSpeed = 5.0f;

    private Rigidbody rb;

    private Vector3 direction;

    


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = Vector3.zero;
        //en avant
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction += -Vector3.forward * Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction = Vector3.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction = -Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(direction * Speed * Time.deltaTime);
            direction = Vector3.left * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }


        gameObject.transform.position += direction * Speed * Time.deltaTime;

    }
}
