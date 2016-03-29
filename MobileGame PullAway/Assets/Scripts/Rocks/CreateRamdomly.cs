using UnityEngine;
using System.Collections;


public class CreateRamdomly : MonoBehaviour  {
	public GameObject PreFab,PreFab1,PreFab2,PreFab3,PreFab4,PreFab5,PreFab6,PreFab7,PreFab8 ;
    public Sprite sp, sp1, sp2, sp3, sp4, sp5, sp6, sp7, sp8, sp9, sp10, sp11, sp12, sp13, sp14, sp15, sp16, sp17, sp18, sp19, sp20, sp21, sp22, sp23, sp24, sp25, sp26;
    public ArrayList Asprites = new ArrayList();
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
        // Physics2D.IgnoreLayerCollision(31, 30, true);
        Cont = 0;
        Asprites.Add(sp);
        Asprites.Add(sp1);
        Asprites.Add(sp2);
        Asprites.Add(sp3);
        Asprites.Add(sp4);
        Asprites.Add(sp5);
        Asprites.Add(sp6);
        Asprites.Add(sp7);
        Asprites.Add(sp8);
        Asprites.Add(sp9);
        Asprites.Add(sp10);
        Asprites.Add(sp11);
        Asprites.Add(sp12);
        Asprites.Add(sp13);
        Asprites.Add(sp14);
        Asprites.Add(sp15);
        Asprites.Add(sp16);
        Asprites.Add(sp17);
        Asprites.Add(sp18);
        Asprites.Add(sp19);
        Asprites.Add(sp20);
        Asprites.Add(sp21);
        Asprites.Add(sp22);
        Asprites.Add(sp23);
        Asprites.Add(sp24);
        Asprites.Add(sp25);
        Asprites.Add(sp26);

        if (GeneralAttrib.arcade)
        {
            if (GeneralAttrib.lvlArcade > 5 && GeneralAttrib.lvlArcade <= 10)
            {
                PreFab.GetComponent<SpriteRenderer>().sprite = sp;
                PreFab1.GetComponent<SpriteRenderer>().sprite = sp1;
                PreFab2.GetComponent<SpriteRenderer>().sprite = sp2;
                PreFab3.GetComponent<SpriteRenderer>().sprite = sp3;
                PreFab4.GetComponent<SpriteRenderer>().sprite = sp4;
                PreFab5.GetComponent<SpriteRenderer>().sprite = sp5;
                PreFab6.GetComponent<SpriteRenderer>().sprite = sp6;
                PreFab7.GetComponent<SpriteRenderer>().sprite = sp7;
                PreFab8.GetComponent<SpriteRenderer>().sprite = sp8;
            }
            else if (GeneralAttrib.lvlArcade > 10 && GeneralAttrib.lvlArcade <= 15)
            {
                PreFab.GetComponent<SpriteRenderer>().sprite = sp9;
                PreFab1.GetComponent<SpriteRenderer>().sprite = sp10;
                PreFab2.GetComponent<SpriteRenderer>().sprite = sp11;
                PreFab3.GetComponent<SpriteRenderer>().sprite = sp12;
                PreFab4.GetComponent<SpriteRenderer>().sprite = sp13;
                PreFab5.GetComponent<SpriteRenderer>().sprite = sp14;
                PreFab6.GetComponent<SpriteRenderer>().sprite = sp15;
                PreFab7.GetComponent<SpriteRenderer>().sprite = sp16;
                PreFab8.GetComponent<SpriteRenderer>().sprite = sp17;
            }
            else if (GeneralAttrib.lvlArcade > 15 && GeneralAttrib.lvlArcade <= 20)
            {
                PreFab.GetComponent<SpriteRenderer>().sprite = sp18;
                PreFab1.GetComponent<SpriteRenderer>().sprite = sp19;
                PreFab2.GetComponent<SpriteRenderer>().sprite = sp20;
                PreFab3.GetComponent<SpriteRenderer>().sprite = sp21;
                PreFab4.GetComponent<SpriteRenderer>().sprite = sp22;
                PreFab5.GetComponent<SpriteRenderer>().sprite = sp23;
                PreFab6.GetComponent<SpriteRenderer>().sprite = sp24;
                PreFab7.GetComponent<SpriteRenderer>().sprite = sp25;
                PreFab8.GetComponent<SpriteRenderer>().sprite = sp26;
            }

        }
        
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
        if (GeneralAttrib.metros > 20)
        {
            if (GeneralAttrib.type == 1)
            {
                Time.timeScale = 1;
                powerups.Ptrophie = 50;
                Static.Estatico = false;
                GeneralAttrib.Damage = 1.1f;
                GeneralAttrib.metros = 0f;
                GeneralAttrib.Life = 100;
                GeneralAttrib.nivel = 1;
            }
            else if (GeneralAttrib.type == 2)
            {
                Time.timeScale = 1;
                powerups.Ptrophie = 5;
                Static.Estatico = false;
                GeneralAttrib.Damage = 1.4f;
                GeneralAttrib.metros = 0f;
                GeneralAttrib.Life = 100;
                GeneralAttrib.nivel = 2;
            }
            spriteRenderer.sprite = (Sprite)Asprites[Tipo];
        }
        else if (GeneralAttrib.metros > 60)
        {
            if (GeneralAttrib.type == 1)
            {
                Time.timeScale = 1;
                powerups.Ptrophie = 5;
                Static.Estatico = false;
                GeneralAttrib.Damage = 1.4f;
                GeneralAttrib.Life = 100;
                GeneralAttrib.nivel = 2;
            }
            else if (GeneralAttrib.type == 2)
            {
                powerups.Ptrophie = 12;
                Time.timeScale = 1;
                Static.Estatico = false;
                GeneralAttrib.Damage = 1.7f;
                GeneralAttrib.Life = 100;
                GeneralAttrib.nivel = 3;
            }
            spriteRenderer.sprite = (Sprite)Asprites[Tipo+9];
        }
        else if (GeneralAttrib.metros > 80)
        {
            if (GeneralAttrib.type == 2)
            {
                Time.timeScale = 1;
                powerups.Ptrophie = 5;
                Static.Estatico = false;
                GeneralAttrib.Life = 100;
                GeneralAttrib.nivel = 4;
            }
            else if (GeneralAttrib.type == 1)
            {
                powerups.Ptrophie = 12;
                Time.timeScale = 1;
                Static.Estatico = false;
                GeneralAttrib.Damage = 1.7f;
                GeneralAttrib.Life = 100;
                GeneralAttrib.nivel = 3;
            }
            spriteRenderer.sprite = (Sprite)Asprites[Tipo + 18];
        }
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
