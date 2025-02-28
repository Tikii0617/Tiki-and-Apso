using UnityEngine;

public class TriggerFightAnimation : MonoBehaviour
{
    public Animator animator; 

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fight"); 
            Debug.Log("Fight animation triggered!");
        }
    }
}