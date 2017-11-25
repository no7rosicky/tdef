using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

	private GameObject turretToBuild;

	public static BuildManager instance;

	void Awake ()
	{
		if (instance != null)
		{
			Debug.LogError ("More than one BuildManager in scene!");
			return;
		}

		instance = this;
		
	}

	public GameObject standardTurretPrefab;

	void Start ()
	{
		turretToBuild = standardTurretPrefab;
	}

	public GameObject GetTurretToBuild ()
	{
		return turretToBuild;
	}
}
