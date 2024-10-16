using UnityEngine;
using UnityEngine.AI;

public class MonsterAI : MonoBehaviour
{
    public NavMeshAgent ai;
    public Animator anim;
    public Transform player;
    Vector3 dest;
    PickupLetter pickUpScript;

    private void Start()
    {
        pickUpScript = GameObject.FindGameObjectWithTag("Pages").GetComponent<PickupLetter>();

        //pickUpScript.GetComponent<"PickupLetter">();
    }

    void Update()
    {
        dest = player.position;
        ai.destination = dest;
        if (PickupLetter.pagesCollected == 1)
        {
            ai.speed = 1.5f;
            anim.speed = 0.2f;
        }
        if (PickupLetter.pagesCollected == 2)
        {
            ai.speed = 1.7f;
            anim.speed = 0.4f;
        }
        if (PickupLetter.pagesCollected == 3)
        {
            ai.speed = 1.9f;
            anim.speed = 0.6f;
        }
        if (PickupLetter.pagesCollected == 4)
        {
            ai.speed = 2.5f;
            anim.speed = 0.8f;
        }
        if (PickupLetter.pagesCollected == 5)
        {
            ai.speed = 3f;
            anim.speed = 1f;
        }
        if (PickupLetter.pagesCollected == 6)
        {
            ai.speed = 3.5f;
            anim.speed = 1.2f;
        }
        if (PickupLetter.pagesCollected == 7)
        {
            ai.speed = 3.8f;
            anim.speed = 1.4f;
        }
        if (PickupLetter.pagesCollected == 8)
        {
            ai.speed = 4f;
            anim.speed = 1.6f;
        }
    }
}