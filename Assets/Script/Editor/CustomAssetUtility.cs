using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class CustomAssetUtility
{
    public static void CreateConversation()
    {
        var conversation = ScriptableObject.CreateInstance<Conversation>();

        AssetDatabase.CreateAsset(conversation, "Assets/conversation.asset");

        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = conversation;
    }
}
