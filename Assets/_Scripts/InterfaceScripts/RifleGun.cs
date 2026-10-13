using TMPro;
using UnityEngine;

public class RifleGun : MonoBehaviour, IShootable
{
    public GameObject shootText;
    public void Shoot()
    {
        GameObject shootingText = Instantiate(shootText, transform.position, Quaternion.identity);
        shootingText.GetComponentInChildren<TextMeshProUGUI>().text = "pew pew";
        Destroy(shootingText, 2f);
    }
}
