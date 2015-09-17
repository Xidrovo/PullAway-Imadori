using UnityEngine;
using System.Collections;

public class moveTowards : MonoBehaviour {

    private Vector3 final= new Vector3(0,3.2f,-0.1f);
    public float speed;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position = Vector3.MoveTowards(this.transform.position, final, speed * Time.deltaTime);
    }
}
