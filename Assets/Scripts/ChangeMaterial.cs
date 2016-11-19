using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

    
    void Start()
    {

    }

	
	// Update is called once per frame
	void Update () {
        string materialToChangeTo = null;

        Material materials = (Material)Resources.Load(materialToChangeTo, typeof(Material));
        if (materials == null)
            return;

        if (Input.GetKeyDown(KeyCode.Alpha1))
            materialToChangeTo = "Bricks";
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            materialToChangeTo = "Droplets";
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            materialToChangeTo = "Grid";
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            materialToChangeTo = "Leopard";
        else if (Input.GetKeyDown(KeyCode.Alpha5))
            materialToChangeTo = "Red";
        else if (Input.GetKeyDown(KeyCode.Alpha6))
            materialToChangeTo = "Tiles";

        else
            return;
        MeshRenderer rend = GetComponent<MeshRenderer>();

        /*   if (rend == null)
               return;*/
        rend.material = materials;

        //test
        Debug.Log("Finished");

    }
}
