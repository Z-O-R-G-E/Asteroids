﻿using System.Collections.Generic;


namespace Asteroids.Composite
{
    internal sealed class Detachment : IAttack
    {
        private List<IAttack> _attacks = new List<IAttack>();
        
        public void AddUnit(IAttack attack)
        {
            _attacks.Add(attack);
        }

        public void RemoveUnit(IAttack attack)
        {
            _attacks.Remove(attack);
        }

        public void Attack()
        {
            foreach(IAttack attack in _attacks)
            {
                attack.Attack();
            }
        }
    }
}
