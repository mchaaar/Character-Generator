using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Character {

    public string name;
    public List<BodyPart> bodyParts = new List<BodyPart>();

}

[System.Serializable]
public class BodyPart {

    public string name;
    public Vector3 position;
    public bool required;

}
