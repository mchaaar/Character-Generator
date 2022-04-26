using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterGenerator : MonoBehaviour {

    public ScriptableBodyParts allBodyParts;

    private Character newCharacter;

    void Start(){

        newCharacter = gameObject.GetComponent<NewCharacter>().character;

        New();

    }

    public void New(){

        for (int i = 0; i < newCharacter.bodyParts.Count; i++) {



        }

    }

}
