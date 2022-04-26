using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Character {

    public string name;
    public List<CharacterBodyPart> bodyParts = new List<CharacterBodyPart>();

}

[System.Serializable]
public class BodyPart {

    public enum part {

        Head,
        Torso,

    };

    [Space(6)]
    public part partType;

    [Space(6)]
    public string customName;

    [Space(6)]
    public GameObject prefab;

}

[System.Serializable]
public class CharacterBodyPart : BodyPart {

    [Space(6)]
    public string name;

    [Space(6)]
    public Vector3 position;

    [Space(6)]
    public bool required;

}
