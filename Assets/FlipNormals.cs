﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FlipNormals : MonoBehaviour {


	void Start()
 {
     var mesh = (transform.GetComponent("MeshFilter") as MeshFilter).mesh;
     mesh.uv = mesh.uv.Select(o => new Vector2(1 - o.x, o.y)).ToArray();
     mesh.triangles = mesh.triangles.Reverse().ToArray();
     mesh.normals = mesh.normals.Select(o => -o).ToArray();
 }


}
