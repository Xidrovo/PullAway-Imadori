using UnityEngine;
using System.Collections;

public class CreateRamdomly : MonoBehaviour {
	public GameObject PreFab;
	public Canvas canva;
	private GameObject NormalTable;
	private int Max, Cont;
	private float ZRotation;
	private Quaternion Rotation;
	
	// Use this for initialization
	void Start () {
		Max = Random.Range (5, 10);
		Cont = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (Cont <= Max)
		{
			CreateObject();
			Cont++;
		}
	
	}

	//This Method will create everything the object needs, it use a "Prefab" to have the scripts, sprites, etc.
	public void CreateObject()
	{
		//With this I will get the "z" rotation of the object... this "z" rotation is the one that really
		//rotate the object as we want to rotate.
		Rotation = RotAleatoria ();
		ZRotation = Rotation.eulerAngles.z;

		//With this we initiate the object as a game object.
		PreFab.name = "Roquita" + "" + (Cont + 1);
		NormalTable = (GameObject) Instantiate (PreFab, PosEnElOrigen() , Rotation );
	}

	//This method will give me a random vector3... that means, a random position... buuuut!!...
	//This position will be random but according to the rotation of the object.
	public Vector3 PosEnElOrigen()
	{
		Vector3 Vector = canva.transform.position;
		Vector.z = Cont;

		return Vector;
	}
	
	public Quaternion RotAleatoria()
	{
		int x = 0;
		int y = 0;
		int z = Random.Range (0, 360);

		Quaternion Rot = Quaternion.Euler(x,y,z);

		return Rot;
	}	
}
