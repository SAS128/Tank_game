﻿namespace TankGame.Logic
{
    class Field
    {
        public string FieldName { get; set; }

        public FieldObject[,] fieldobjects;

        public Point size { get; set; }
        public Field()
        {
            size = new Point(10, 5);
            fieldobjects =new FieldObject[10,5];
            FieldName = "New field";
        }

        public Field(string name, Point size, FieldObject[,] objts)
        {
            FieldName = name;
            fieldobjects = objts;
            this.size = size;
        }

        public void AddFieldObject(FieldObject newobj)
        {
            fieldobjects[0, fieldobjects.Length] = newobj; 
        }
        // :\

    }
}
