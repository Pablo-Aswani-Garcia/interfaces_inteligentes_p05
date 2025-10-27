using UnityEngine;

public class move_forwards : MonoBehaviour
{   
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            player.transform.position = Vector3.MoveTowards(player.transform.position, hit.point, 2f * Time.deltaTime);
        }
    }
}

