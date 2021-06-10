using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
	public Body Sun;
	public Body Earth;
	public Body Moon;
	public Body Mars;
	public Body Venera;

	public void GravityConst_1(string newStr)
	{
		Sun.GRAVITY_CONST = 673;
		Earth.GRAVITY_CONST = 673;
		Moon.GRAVITY_CONST = 673;
		Mars.GRAVITY_CONST = 673;
		Venera.GRAVITY_CONST = 673;
	}
}
