using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private readonly Vector3 _rotation = new Vector3(15f, 30f, 45f);

	void Update () {
		transform.Rotate(_rotation * Time.deltaTime);
	}
}
