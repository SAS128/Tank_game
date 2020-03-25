namespace TankGame.Logic
{
    class Field
    {
        public string FieldName { get; set; }

        public FieldObject[,] fieldobjects;

        public Point size { get; set; }
        public Field()
        {
            size.X = 40;
            size.Y = 40;
            fieldobjects =new FieldObject[40,40];
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
