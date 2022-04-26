using UnityEngine;

[System.Serializable]
public class BodyPart {

    public enum Part {

        Head,
        Torso,

    };

    [Space(6)]
    public Part part;

    [Space(6)]
    public string customName;

    [Space(6)]
    public GameObject prefab;

}
