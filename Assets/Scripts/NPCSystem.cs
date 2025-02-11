using System;
using UnityEngine;
using DialogueEditor;

public class NPCSystem : MonoBehaviour
{
    [SerializeField] private NPCConversation dialogue;

    bool playerDetected = false;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            playerDetected = true;
        }
    }

    private void Update() {
        if(playerDetected && Input.GetKeyDown(KeyCode.F)) {
           DialogueEditor.ConversationManager.Instance.StartConversation(dialogue);
        }
    }
}
