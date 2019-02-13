using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[ExecuteInEditMode]

public class CustomTerrain : MonoBehaviour {

    //void Awake()
    //{
    //    SerializedObject tagManager = new SerializedObject(
    //        AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
    //    SerializedProperty tagProp = tagManager.FindProperty("tags");

    //    AddTag(tagProp, "Terrain");
    //    AddTag(tagProp, "Cloud");
    //    AddTag(tagProp, "Shore");

    //    tagManager.ApplyModifiedProperties();

    //    this.gameObject.tag = "Terrain";
    //}

    //void AddTag(SerializedProperty tagProp, string newTag)
    //{
    //    bool found = false;

    //    for (int i = 0; i < tagProp.arraySize; i++)
    //    {
    //        SerializedProperty t = tagProp.GetArrayElementAtIndex(i);
    //        if (t.stringValue.Equals(newTag)) { found = true; break; }
    //    }

    //    if(!found)
    //    {
    //        tagProp.InsertArrayElementAtIndex(0);
    //        SerializedProperty newTagProp = tagProp.GetArrayElementAtIndex(0);
    //        newTagProp.stringValue = newTag;
    //    }
    //}

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
