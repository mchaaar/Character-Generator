using UnityEngine;

[System.Serializable]
public class CharacterBodyPart : Variant {

    [Space(6)]
    public string variantName;

    [Space(6)]
    public int selectedIndex;

    [Space(6)]
    public Vector3 position;

    [Space(6)]
    public bool required;

}
