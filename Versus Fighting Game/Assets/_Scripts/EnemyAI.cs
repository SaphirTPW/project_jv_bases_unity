using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private Transform target = null;
    public int maxRange;
    public int minRange;
    private float Speed = 10.0f;
    public float Power;


    void Start()
    {
       
        
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("I got you on my sight ! *^*");
        if (other.tag == "P1") target = other.transform;
  
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("See ya buddy ! ;)");
        if (other.tag == "P1") target = null;
    }

    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.layer == 8 && gameObject.tag != other.gameObject.tag)
        {
            other.gameObject.GetComponent<Combat>().Knockback(Power);
            Power = Power + 100f;
        }
    }


    // Update is called once per frame
    void Update ()
    {
       
        if (target == null) return;
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        bool tooClose = distance < minRange;
        Vector3 direction = /*tooClose ? Vector3.back :*/ Vector3.forward;
        transform.Translate(direction * Time.deltaTime);
	}

    public void Knockback(float power)
    {
        GetComponent<Rigidbody>().AddForce(-transform.forward * power);
    }
}
