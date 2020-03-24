
using System.Collections.Generic;
namespace TankGame
{
    class Field
    {
        public string FieldName { get; set; }

        public FieldObject[,] fieldobjects;

        public Field()
        {
            fieldobjects =new FieldObject[40,40];
            FieldName = "New field";
        }

        public Field(string name, FieldObject[,] objts)
        {
            FieldName = name;
            fieldobjects = objts;
        }

        public void AddFieldObject(FieldObject newobj)
        {
            fieldobjects[0, fieldobjects.Length] = newobj; 
        }
        // :\

    }
}
