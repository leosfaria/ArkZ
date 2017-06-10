using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

	public Material material;
	public List<Material> randomMaterials;

	// Use this for initialization
	void Start () {
		Transform blockVFX = this.transform.Find("VFX");

		Renderer rend = blockVFX.GetComponent<Renderer>();

		if (!material) {
			int index = Random.Range(0, randomMaterials.Count);
			material = randomMaterials[index];
		}

		rend.material = material;
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
