using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;
	public float speed = 10.0f;
	public float xRange = 15.0f;
	public GameObject projectilePrefab;

	void Update()
	{
		MovePlayer();
		CheckBounds();
		ShootProjectile();
	}

	// Movimiento horizontal del jugador
	private void MovePlayer()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
	}

	// Restringe al jugador dentro del rango permitido
	private void CheckBounds()
	{
		if (transform.position.x < -xRange)
		{
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		else if (transform.position.x > xRange)
		{
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
	}

	// Dispara un proyectil cuando se presiona la barra espaciadora
	private void ShootProjectile()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
	}
}
