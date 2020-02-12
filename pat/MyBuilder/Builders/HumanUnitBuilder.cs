using MyBuilder.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBuilder.Builders
{
    public class HumanUnitBuilder : IUnitBuilder
    {
        protected Unit _unit = new Unit();

        public HumanUnitBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._unit = new Unit();
        }

        public void CreateTransport()
        {
            _unit.Transport = new Transport() { ID = 2 };
        }

        public void CreateWeapon()
        {
            _unit.Weapon = new Weapon();
        }

        public void CreateArmor()
        {
            _unit.Armor = new Armor();
        }

        public Unit GetUnit()
        {
            Unit result = _unit;
            Reset();
            return result;
        }
    }
}
