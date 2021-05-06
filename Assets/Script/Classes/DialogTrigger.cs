using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Conversation conversation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ConversationManager.Instance.StartConversation(conversation);
    }
}
