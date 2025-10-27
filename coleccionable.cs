using UnityEngine;
using UnityEngine.Rendering.UI;

public class coleccionable : MonoBehaviour
{
    bool movedTowardsPlayer = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    void StartMovingTowardsPlayer()
    {
        movedTowardsPlayer = true;
    }
    void StopMovingTowardsPlayer()
    {
        movedTowardsPlayer = false;
    }
    void MoveTowardsPlayer() {
        Transform player = Camera.main.transform;
        float step = 2f * Time.deltaTime; // adjust speed as needed
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }
    public void OnPointerEnter() {
        Debug.Log("Gaze entered");
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (movedTowardsPlayer) {
            MoveTowardsPlayer();
        }
        
    }
}
