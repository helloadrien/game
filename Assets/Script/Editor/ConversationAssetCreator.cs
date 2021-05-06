using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

class ConversationAssetCreator : MonoBehaviour
{
    [MenuItem("Assets/Create/Conversation")]
    public static void CreateAsset() 
    {
        CustomAssetUtility.CreateConversation();
    }
}
