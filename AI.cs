using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {
	public Animator anim;
	public float speed;
	public GameObject target;
	public bool playAnim;

	void Start () {
		anim = GetComponent<Animator>();
		target = GameObject.Find ("Player");
		anim.Play ("walk", -1, 0f);
	}

	void Update () {
		Vector3 targetPos = new Vector3 (target.transform.position.x, this.transform.position.y, target.transform.position.z);

		this.transform.LookAt (targetPos);
		this.transform.Translate (Vector3.forward * 0.01f);

		float pos = Vector3.Distance (target.transform.position, transform.position);

		if (pos < 3f && playAnim == true) {
			anim.Play ("mile attack1", -1, 0f);
			playAnim = false;
		}
		if (pos > 3f && playAnim == false) {
			anim.Play ("walk", -1, 0f);
			playAnim = true;
		}
	}
}