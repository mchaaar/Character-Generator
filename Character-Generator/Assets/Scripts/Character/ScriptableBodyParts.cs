using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Object/Body Parts List", fileName = "Body Parts")]
public class ScriptableBodyParts : ScriptableObject {

    public List<BodyPart> bodyParts = new List<BodyPart>();

}
