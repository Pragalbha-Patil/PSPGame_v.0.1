using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gManager;
    
    void OnTriggerEnter()
    {
        gManager.CompleteLevel();
    }


}
