using UnityEngine;
using System.Collections;

public class PositionFix : MonoBehaviour
{

	public Transform target; 
	
	void Update()
	{
		transform.position = target.transform.position;
	}
}