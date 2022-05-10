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

            for (int ii = 0; ii < allBodyParts.bodyParts.Count; ii++){

                if (newCharacter.bodyParts[i].name == allBodyParts.bodyParts[ii].name){

                    int random = Random.Range(0, allBodyParts.bodyParts[ii].variants.Count);

                    newCharacter.bodyParts[i].prefab = allBodyParts.bodyParts[ii].variants[random].prefab;
                    newCharacter.bodyParts[i].variantName = allBodyParts.bodyParts[ii].variants[random].name;
                    newCharacter.bodyParts[i].selectedIndex = random;
                    Instantiate(i);

                }

            }

        }

    }

    public void Instantiate(int i){

        Instantiate(newCharacter.bodyParts[i].prefab, newCharacter.bodyParts[i].position, Quaternion.identity);

    }

}
