
using System.Collections.Generic;
namespace TankGame
{
    class Field
    {
        public string FieldName { get; set; }

        public List<FieldObject> fieldobjects;

        public Field()
        {
            fieldobjects = new List<FieldObject>();
            FieldName = "New field";
        }

        public Field(string name, List<FieldObject> objts)
        {
            FieldName = name;
            fieldobjects = objts;
        }

        public void AddFieldObject(FieldObject newobj)
        {
            fieldobjects.Add(newobj);
        }


    }
}
