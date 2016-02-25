﻿using UnityEngine;
using System.Collections;

public class CreateRamdomly : MonoBehaviour  {
	public GameObject PreFab,PreFab1,PreFab2,PreFab3,PreFab4,PreFab5,PreFab6,PreFab7,PreFab8 ;
    public GameObject muros;
	private float Radio =2f;
	//	public Canvas canva;
	private GameObject NormalTable, NT;
	public ArrayList Aprefabs = new ArrayList();

	public static ArrayList AllRocks = new ArrayList();

	private int Cont, Tipo, OneCont;
	private float ZRotation, angle;
	private Quaternion Rotation;
	private SpriteRenderer spriteRenderer;
    private SpriteRenderer SP;
    // Use this for initialization
    void Start () {
		Cont = 0;
		Aprefabs.Add(PreFab);
		Aprefabs.Add(PreFab1);
		Aprefabs.Add(PreFab2);
		Aprefabs.Add(PreFab3);
		Aprefabs.Add(PreFab4);
		Aprefabs.Add(PreFab5);
		Aprefabs.Add(PreFab6);
		Aprefabs.Add(PreFab7);
		Aprefabs.Add(PreFab8);
		Eliminar.ReloadLayout =GeneralAttrib.maxi - 1;
	}
	
	// Update is called once per frame
	void Update () {

        if (Cont < GeneralAttrib.maxi)
        {
            Tipo = Random.Range(0, 8);
            CreateObject(Tipo);
            Cont++;
        }
       
		if (Eliminar.Duty == true && (GeneralAttrib.arcade==false)) 
		{
			Tipo = Random.Range (0, 8);
			CreateObjectOnRunTime(Tipo);
			Eliminar.Duty = false;
		}
	
	}

	public void CreateObjectOnRunTime(int tipo)
	{
		//With this I will get the "z" rotation of the object... this "z" rotation is the one that really
		//rotate the object as we want to rotate.
		Rotation = RotAleatoria ();
		ZRotation = Rotation.eulerAngles.z;
        Vector3 pos = PosEnElOrigen(0);
        //With this we initiate the object as a game object.
        if (GeneralAttrib.type == 1)
        {
            ((GameObject)(Aprefabs[tipo])).name = "Roquita" + "" + (Cont + 1);
        }
        else if (GeneralAttrib.type == 2)
        {
            muros.name = "Muro" + "" + (Cont + 1);
            ((GameObject)(Aprefabs[tipo])).name = "Balsa" + "" + (Cont + 1);
            NT = (GameObject)Instantiate(muros, pos, Rotation);
            SP = NT.GetComponent<SpriteRenderer>();
            SP.sortingOrder = 1;
        }
        else
        {
            ((GameObject)(Aprefabs[tipo])).name = "Hoja" + "" + (Cont + 1);
        }
		NormalTable = (GameObject) Instantiate ((GameObject)(Aprefabs[tipo]), pos , Rotation );
		spriteRenderer = NormalTable.GetComponent<SpriteRenderer>();
		spriteRenderer.sortingOrder = 1;
		AllRocks.Insert (0,NormalTable);
        /*AllRocks.Add(NormalTable);
		foreach (GameObject x in CreateRamdomly.AllRocks)
		{
			try
			{
				x.GetComponent<AtribRocks>().SortingUp();
			}catch(System.Exception)
			{
			}
		}*/
        
	}

	//This Method will create everything the object needs, it use a "Prefab" to have the scripts, sprites, etc.
	public void CreateObject(int tipo)
	{
		//With this I will get the "z" rotation of the object... this "z" rotation is the one that really
		//rotate the object as we want to rotate.
		Rotation = RotAleatoria ();
		ZRotation = Rotation.eulerAngles.z;
        Vector3 pos = PosEnElOrigen(Cont);
        //With this we initiate the object as a game object.
        if (GeneralAttrib.type == 1)
        {
            ((GameObject)(Aprefabs[tipo])).name = "Roquita" + "" + (Cont + 1);
        }
        else if (GeneralAttrib.type == 2)
        {
            muros.name = "Muro" + "" + (Cont + 1);
            ((GameObject)(Aprefabs[tipo])).name = "Balsa" + "" + (Cont + 1);
            NT = (GameObject)Instantiate((GameObject)muros, pos, Rotation);
            SP = NT.GetComponent<SpriteRenderer>();
            SP.sortingOrder = Cont + 1;
        }
        else
        {
            ((GameObject)(Aprefabs[tipo])).name = "Hoja" + "" + (Cont + 1);
        }
        
        NormalTable = (GameObject) Instantiate ((GameObject)(Aprefabs[tipo]), pos  , Rotation );
		spriteRenderer = NormalTable.GetComponent<SpriteRenderer>();
		spriteRenderer.sortingOrder = Cont + 1;
		AllRocks.Add (NormalTable);
	}

	//This method will give me a random vector3... that means, a random position... buuuut!!...
	//This position will be random but according to the rotation of the object.
	public Vector3 PosEnElOrigen(int tipo)
	{
		Vector3 Vector = new Vector3(Random.Range (-2.1f, 2.1f),Random.Range (-2.1f, 0.7f),0);
		/*float temp = Radio;
		if (Cont != 0) 
		{
			angle=Cont* 2* Mathf.PI/(Max-1);
			Radio*=-1;
			if(tipo<=5)
			{
				Radio+=0.25f;
			}
			else
			{
				Radio+=-0.75f;
			}
			Vector+=new Vector3 (Mathf.Cos(angle),  Mathf.Sin(angle),0)* Radio ;
		}*/
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
