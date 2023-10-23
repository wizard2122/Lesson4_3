using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{
    private IHealthStat _health;
    
    public void Initialize(IHealthStat healthStat)
    {
        _health = healthStat;
    }

    public void TakeDamage(int damage) => _health.Reduce(damage);
     
    public void Heal(int value) => _health.Add(value);
}
