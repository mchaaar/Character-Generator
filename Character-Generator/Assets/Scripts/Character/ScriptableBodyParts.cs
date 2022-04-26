using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Object/Body Parts List", fileName = "Body Parts")]
public class ScriptableBodyParts : ScriptableObject {

    public List<PartType> bodyParts = new List<PartType>();

}

[System.Serializable]
public class PartType {

    public string name;
    public List<Variant> variants = new List<Variant>();

}
