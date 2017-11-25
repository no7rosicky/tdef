
using UnityEngine;

public class Node : MonoBehaviour {

	public Color hoverColor;

	private Renderer rend;

	private Color startColor;

	private GameObject turret;

	void Start()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
	}

	void OnMouseDown ()
	{
		if (turret != null)
		{
			Debug.Log("Can't Build there! - TODO: Display on screen.");
			return;
		}

		GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
		turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
	
	}

	void OnMouseEnter ()
	{
		rend.material.color = hoverColor;
	}

	void OnMouseExit ()
	{
		rend.material.color = startColor;
	}
}
