public class EnemyModel
{
    public decimal Speed => _speed;
    public decimal Health => _health;
    public decimal Armor => _armor;
    public decimal Damage => _damage;

    private decimal _speed;
    private decimal _health;
    private decimal _armor;
    private decimal _damage;

    public EnemyModel(decimal speed, decimal health, decimal armor, decimal damage)
    {
        _speed = speed;
        _health = health;
        _armor = armor;
        _damage = damage;
    }
}