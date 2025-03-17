using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject projectilePrefab;

    public void FireProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, launchPoint.position, projectilePrefab.transform.rotation);
        Vector3 ogScale = projectile.transform.localScale;

        //flip the projectile's facing direction and movement based on the direction the character is facing at time of launch
        projectile.transform.localScale = new Vector3(ogScale.x * transform.localScale.x > 0 ? 1 : -1, ogScale.y, ogScale.z);
    }
}
