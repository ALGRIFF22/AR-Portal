using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{
	public float lockPos = 0;

	public Transform cameraPos;

    // Update is called once per frame
    void Update()
    {
		transform.position = cameraPos.position;
		transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }
}
