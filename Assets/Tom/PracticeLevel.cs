﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLevel : MonoBehaviour {

	public GameObject ground;
	public GameObject column;
	public GameObject coin;


	// Use this for initialization
	void Start () {
		// Reference to this scene's world_base
		WorldBase wb = GetComponent<WorldBase> ();

		// Adding one column to level
		List<WorldBase.WorldEntry> thisLevel = new List<WorldBase.WorldEntry> ();
		WorldBase.WorldEntry blockentry = new WorldBase.WorldEntry ();
		blockentry.loc = new Vector3 (20, 0, 0);
		blockentry.obj = column;
		thisLevel.Add(blockentry);

		float blockWidth = ground.GetComponent<BoxCollider2D> ().size.x; //   bounds.size.x;

		// Adding 80 brown_grounds to level
		for (int i = 0; i < 80; i++) {
			WorldBase.WorldEntry entry = new WorldBase.WorldEntry ();

			entry.loc = new Vector3 (i*blockWidth, 0, 0);
			entry.obj = ground;
			thisLevel.Add (entry);
		}

		for (int i = 0; i < 10; i++) {
			WorldBase.WorldEntry entry = new WorldBase.WorldEntry ();

			if (i == 4) {
				entry.loc = new Vector3 (i * 5, 3, 0);
			} else {
				entry.loc = new Vector3 (i*5, 1, 0);
			}
				
			entry.obj = coin;
			thisLevel.Add (entry);
		}

		// Sorting level by x position
		thisLevel.Sort((x, y) => x.loc.x.CompareTo(y.loc.x));

		wb.WorldStart ();


	}
	
	// Update is called once per frame
	void Update () {
//		WorldUpdate ();
	}
}
