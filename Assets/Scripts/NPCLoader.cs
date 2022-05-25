using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLoader : MonoBehaviour
{
    [SerializeField] Vector3 targetPosition;
    [SerializeField] float moveSpeed = 5f;

    NPCDialogue npcDialogue;  

    void Awake()
    {
        npcDialogue = GetComponent<NPCDialogue>();
    }
    
    void Start()
    {
        //SpawnNPC();
    }


    void Update()
    {
        MoveIn();
    }

    // void SpawnNPC()
    // {
            // Selects random NPC from list and spawns them
    // }
    
    void MoveIn()
    {
        // Moves NPC sprite from off-screen to 0,0,0
        float delta = moveSpeed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, delta);
        // Need to trigger ShowDialogue once the NPC moves into position
    }

    

}
