using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {

	public float Power;
	public float sheild;
	//public string test;

	void Awake(){
		//coroutine recharge bouclier
		StartCoroutine (sheildrecharge ());
	}

	IEnumerator sheildrecharge(){
		while (true) {
			// recharge sheild toutes les secondes jusqu'a 10 unitées
			if (sheild < 10f) {
				sheild = sheild + 1f;
			}
			yield return new WaitForSeconds (1);
		}
	}

	//collider de hit
	void OnTriggerStay(Collider other){
		//si on appui sur E et que le P2 est dans le collider ( layer player et tag différent de p1)
		if (Input.GetKeyDown(KeyCode.E) && other.gameObject.layer == 8 && gameObject.tag != other.gameObject.tag)
		{
			//on lance le function knockback sur le script de combat du p2 avec la variable de power du P1
			other.gameObject.GetComponent <EnemyAI>().Knockback (Power);
			//on augmente de 100 la power du p1
			Power = Power + 100f;
		}
	}

	//fonction knockback ( a copier dans le script de l'IA)
	public void Knockback(float power){
		//si on bloque et que le bouclier est pas a 0
		if (Input.GetKey(KeyCode.A) && sheild >=0) {
			//diminue le sheild
			sheild = sheild - 1f;
		} else {
			//sionon on fait reculer le jeur de la power du P1
			GetComponent<Rigidbody> ().AddForce (-transform.forward * power);
		}
	}
}
