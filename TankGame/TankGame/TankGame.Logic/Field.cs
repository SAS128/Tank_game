
using System.Collections.Generic;
namespace TankGame
{
    class Field
    {
        public string FieldName { get; set; }

        public FieldObject [,] fieldobjects;

        public Field()
        {
            fieldobjects = new FieldObject[10,10];
            FieldName = "default";
        }

        public Field(string name, FieldObject[,] objects)
        {
            FieldName = name;
            fieldobjects = objects;
        }

        public void AddFieldObject(FieldObject newobj)
        {
            fieldobjects[0, fieldobjects.Length] = newobj; 
        }

    }
}
