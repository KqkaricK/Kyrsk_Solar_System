using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Ui : MonoBehaviour
{

	public Body Sun;
	public Body Earth;
	public Body Moon;
	public Body Mars;
	public Body Venera;

	public void GravityConst_EndEdit(string newStr)
	{
		Sun.GRAVITY_CONST = float.Parse(newStr);
		Earth.GRAVITY_CONST = float.Parse(newStr);
		Moon.GRAVITY_CONST = float.Parse(newStr);
		Mars.GRAVITY_CONST = float.Parse(newStr);
		Venera.GRAVITY_CONST = float.Parse(newStr);
	}
}