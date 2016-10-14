using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private Transform target = null;
    public int maxRange;
    public int minRange;
    private float Speed = 5.0f;
    

    void Start()
    {
       
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("I got you on my sight ! *^*");
        if (other.tag == "Player") target = other.transform;
  
    }

    void OnTriggerExit(Collider other)
    {
        //Debug.Log("See ya buddy ! ;)");
        if (other.tag == "Player") target = null;
    }


    // Update is called once per frame
    void Update ()
    {
       
        if (target == null) return;
        transform.LookAt(target);
        float distance = Vector3.Distance(transform.position, target.position);
        bool tooClose = distance < minRange;
        Vector3 direction = tooClose ? Vector3.back : Vector3.forward;
        transform.Translate(direction * Time.deltaTime);
	}
}
