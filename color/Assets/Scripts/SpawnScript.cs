using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public GameObject Tile3Colores;
    public GameObject Tile2Colores;
    public GameObject Tile4Colores;

    int random;
	float time;
	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 0.8f) {

            random = Random.Range(0, 3); // 0,1,2

            if(random == 0)
            {
                Instantiate(Tile3Colores, new Vector2(0,250), Quaternion.identity);
            }
            if (random == 1)
            {
                Instantiate(Tile2Colores, new Vector2(0, 250), Quaternion.identity);
            }
            if (random == 2)
            {
                Instantiate(Tile4Colores, new Vector2(0, 250), Quaternion.identity);
            }
            //HACER STACK
            time = 0;
		}

	}
}
