using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public Projectile projectileUp;
    public Projectile projectileDown;
    public Projectile projectileLeft;
    public Projectile projectileRight;
    public Transform muzzle;
	public float bulletSpeed;
    public float fireRate;
	private float nextFireTime;
	public float Bullets = 3;
    public float myScale = 6.3f;
    public bool _shoot = false;
    private float shotTimer = 0.2f;

	void Update()
    {
        if (!_shoot)
        {
            if (Input.GetKeyDown("i"))
            {
                ShootUp();
                _shoot = true;
            }
            if (Input.GetKeyDown("l"))
            {
                ShootDown();
                _shoot = true;
            }
            if (Input.GetKeyDown("j"))
            {
                ShootLeft();
                _shoot = true;
            }
        }
        if(_shoot)
        {
            shotTimer -= Time.deltaTime;
        }
        if(shotTimer < 0)
        {
            shotTimer = 0.2f;
            _shoot = false;
        }
    }



	private void ShootUp()
	{

		Projectile newProjectile = Instantiate (projectileUp, muzzle.position, muzzle.rotation) as Projectile;
		newProjectile.SetSpeed (bulletSpeed);
		nextFireTime = Time.time + fireRate;
        newProjectile.tag = "up";
        newProjectile.transform.localScale = new Vector3(myScale, myScale, myScale);
	}
    private void ShootDown()
    {

        Projectile newProjectile = Instantiate(projectileDown, muzzle.position, muzzle.rotation) as Projectile;
        newProjectile.SetSpeed(bulletSpeed);
        nextFireTime = Time.time + fireRate;
        newProjectile.tag = "down";
        newProjectile.transform.localScale = new Vector3(myScale, myScale, myScale);
    }
    private void ShootLeft()
    {

        Projectile newProjectile = Instantiate(projectileLeft, muzzle.position, muzzle.rotation) as Projectile;
        newProjectile.SetSpeed(bulletSpeed);
        nextFireTime = Time.time + fireRate;
        newProjectile.tag = "left";
        newProjectile.transform.localScale = new Vector3(myScale, myScale, myScale);
    }
    private void ShootRight()
    {

        Projectile newProjectile = Instantiate(projectileRight, muzzle.position, muzzle.rotation) as Projectile;
        newProjectile.SetSpeed(bulletSpeed);
        nextFireTime = Time.time + fireRate;
        newProjectile.tag = "right";
        newProjectile.transform.localScale = new Vector3(myScale, myScale, myScale);
    }


}
