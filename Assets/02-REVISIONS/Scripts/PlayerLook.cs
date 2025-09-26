using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    void Update()
    {
        //On crée un rayon qui part de la position de la souris sur la caméra et se dirige vers le monde
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Si le rayon touche un objet de la scène, ...
        if(Physics.Raycast(ray, out RaycastHit hit))
        {
            //..., on récupère son point de contact, ...
            Vector3 lookPosition = hit.point;
            //..., on lui donne la même hauteur que celle du personnage afin qu'il ne regarde jamais vers le haut ou le bas, ...
            lookPosition.y = transform.position.y;
            //..., et on dit au personnage de regarder ce point :
            transform.LookAt(lookPosition);
        }
    }
}
