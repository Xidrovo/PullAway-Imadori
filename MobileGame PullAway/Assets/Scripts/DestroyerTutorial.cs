using UnityEngine;
using System.Collections;

public class DestroyerTutorial : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D Trigg)
    {
        try
        {
            Destroy(Trigg.gameObject);
        }
        catch (System.Exception e)
        {

        }
    }
}
