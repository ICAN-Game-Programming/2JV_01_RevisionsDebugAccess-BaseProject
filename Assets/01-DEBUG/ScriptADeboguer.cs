// using System.Collections;
//                                                 using System.Collections.Generic;
//         using UnityEngine;
//
// public class ScriptADeboguer :                         MonoBehaviour
// {
//     private float vitesse = 1.5;
// private Vector3                 positionCible;
//
// void Start ()
//                                 {
//         //Note : Random.insideUnitSphere renvoie un Vector3 aléatoire compris dans une sphere de 1m de diamètre
//                 //Pas d'erreur sur la ligne suivante :
//     positionCible = Random.insideUnitSphere;
//     }
// 	
// 	void Update ()
//     {
//     Vector3 nouvellePosition = Vector3.MoveTowards(              Transform.position, positionCible, vitesse);
//
// transform.position += nouvellePosition;
//
//     if (transform.position = positionCible)
// {
// //Idem : pas d'erreur ici :
// positionCible = Random.insideUnitSphere * 2f;
//   }
//     }
//                                             }
