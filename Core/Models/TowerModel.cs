
namespace Core.Models
{
    public class TowerModel
    {
        public decimal Radius => _radius * LevelCoefficient;
        public decimal Speed => _speed * LevelCoefficient;
        public decimal Damage => _damage * LevelCoefficient;
        public decimal LevelCoefficient { get; private set; } = 1;

        private decimal _radius;
        private decimal _speed;
        private decimal _damage;

        public TowerModel(decimal radius, decimal speed, decimal damage)
        {
            _radius = radius;
            _speed = speed;
            _damage = damage;
        }

        public void LevelUp(decimal newLevel)
        {
            LevelCoefficient = newLevel;
        }
    }
}
