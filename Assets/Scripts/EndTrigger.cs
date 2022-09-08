
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public  GameManager gameManager;
    
    void OnTriggerEnter()
    {
        gameManager.CompletedLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
