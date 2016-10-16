using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public int maxRange;
    public int minRange;
    private float Speed = 10.0f;
    public float Power;
	public GameObject target;


    void Start()
    {
       
        
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
        float distance = Vector3.Distance(transform.position, target.transform.position);
        Vector3 direction = /*tooClose ? Vector3.back :*/ Vector3.forward;
        transform.Translate(direction * Time.deltaTime);
	}

    public void Knockback(float power)
    {
        GetComponent<Rigidbody>().AddForce(-transform.forward * power);
    }
}
