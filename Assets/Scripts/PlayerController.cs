using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public GameObject explosion;
	public GameObject laser;
	public GameObject bomb;

	Rigidbody2D rb2d;
	Animator anim;
	public int defautammo = 10;
	private int ammo;
	bool oneShot = true, oneShot2 = true;
	private int level = 1;
	private float tempsnivell;
	public float tempsxnivell = 30;
	public Text CanvasTime;
	public Text CanvasLevel;
	public Text CanvasAmmo;
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		tempsnivell = tempsxnivell;
		CanvasLevel.text = "Level: 1";
		CanvasAmmo.text = "Ammo: 10/10";
		CanvasTime.text = "Time: " + tempsnivell.ToString("f1");
		ammo = defautammo;
	}

	void FixedUpdate()
	{

		if (tempsnivell > 0)
		{
			tempsnivell -= Time.deltaTime;
			CanvasTime.text = "Time: " + tempsnivell.ToString("f1");

		}
		else
        {
			level++;
			CanvasLevel.text = "Level: "+level;
			tempsnivell = tempsxnivell;
			ammo = defautammo;
			CanvasAmmo.text = "Ammo: " + ammo + "/10";


		}


		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		float shoot = Input.GetAxis("Fire1");
		float shoot2 = Input.GetAxis("Fire2");

		if(shoot == 0)
        {
			oneShot = true;
        }

		if (shoot> 0 && ammo > 0 && oneShot)
		{
			oneShot = false;
			Instantiate(laser, transform.position, transform.rotation);
			ammo--;
			CanvasAmmo.text = "Ammo: "+ammo+"/10";


		}

		if (shoot2 == 0)
		{
			oneShot2 = true;
		}

		if (shoot2 > 0 && ammo > 0 && oneShot2)
		{
			oneShot2 = false;
			Instantiate(bomb, transform.position, transform.rotation);
			ammo--;
			CanvasAmmo.text = "Ammo: " + ammo + "/10";


		}

		if (moveVertical > 0)
		{
			anim.SetInteger("speedUp", 1);
		}
		else if (moveHorizontal == 0)
		{
			anim.SetInteger("speedUp", 0);
		}
		else if (moveHorizontal > 0)
		{
			anim.SetInteger("speedUp", 2);
		}
		else if (moveHorizontal < 0)
		{
			anim.SetInteger("speedUp", 3);
		}
		else
		{
			anim.SetInteger("speedUp", 0);
		}
		var movement = new Vector2(moveHorizontal, moveVertical).normalized * speed * Time.deltaTime;
		rb2d.AddForce(movement);

	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Asteroid"))
        {
			this.gameObject.SetActive(false);
			Instantiate(explosion, transform.position, transform.rotation);
			Invoke("Die", 2.0f);

        }
    }

	private void Die()
    {
		SceneManager.LoadScene("GameOver");
	}

}