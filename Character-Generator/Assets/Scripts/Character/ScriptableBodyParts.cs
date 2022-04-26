using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Object/Body Part List", fileName = "Body Parts")]
public class ScriptableBodyParts : ScriptableObject {

    public List<BodyPart> parts = new List<BodyPart>();

}
