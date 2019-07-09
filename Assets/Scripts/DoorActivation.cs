using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Rendering;

public class DoorActivation : MonoBehaviour
{
	[SerializeField]
	private VideoController video;
	[SerializeField]
	private Material[] materials;

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Door")
		{
			Debug.Log("Trigger entered");
			for (int i = 0; i < materials.Length; i ++)
			{
				materials[i].SetInt("_StencilComp", (int)CompareFunction.Always);
			}
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Door")
		{
			Debug.Log("Trigger entered");
			for (int i = 0; i < materials.Length; i++)
			{
				materials[i].SetInt("_StencilComp", (int)CompareFunction.Equal);
			}
		}
	}


}
