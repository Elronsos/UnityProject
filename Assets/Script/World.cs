using UnityEngine;
using System.Collections;

public class World : MonoBehaviour
{
    [SerializeField]
    private GameObject GrassBlock;

    int[,,] field = new int[24, 12, 2];

    Vector2 position;
    // Use this for initialization
    // Generiert eine 24x12 Welt
    void Start()
    {
        /*  z = 0: Block Id
         *  z = 1: Kollision. Definition unten
            0 = bauen & laufen
            1 = bebaut
            2 = nicht bauen & laufen */
 
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                position.x = i;
                position.y = j;
                field[i, j, 0] = 1;
                field[i, j, 1] = 1;
                //setze Gras Objekt an Koordinate (x,y) in Unity
                Instantiate(GrassBlock, position, Quaternion.identity); 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
