using System;

namespace TankGame
{
    class Bonus : FieldObject
    {

        string PropertyName { get; set; }
        int value { get; set; }
        public Bonus()
        {
        }

        public override void Collision(ref FieldObject sender)
        {
            throw new NotImplementedException();
        }
    }
}
