using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
  public Image healthBarImage;
  public  maymun_hareket monkey;
  public void UpdateHealthBar() {
        healthBarImage.fillAmount =  Mathf.Clamp(monkey.health / monkey.maxHealth, 0, 1f);
  }
}