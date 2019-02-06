using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "NameData")]
public class NameData : ScriptableObject {
    public string yourName = "empty"; 
} //muss direkt darunter stehen, sonst funktioniert das nicht. Keine Leerzeile zwischen CreateAssetsMenu und klasse
