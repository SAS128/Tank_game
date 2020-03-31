namespace TankGame.Logic
{
    public class Field
    {
        /// <summary>
        /// The field`s name
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// Two-dimensional array that represents all FieldObject`s children, except PlayerObject`s one.
        /// </summary>
        public FieldObject[,] fieldobjects;
        /// <summary>
        /// Holds a size of dimensions of fieldobjects
        /// </summary>
        public Point size { get; set; }
        /// <summary>
        /// Creates empty array with dimensions 10 on 5. Name = "NewField"
        /// </summary>
        public Field()
        {
            size = new Point(10, 5);
            fieldobjects = new FieldObject[10,5];
            FieldName = "New field";
        }
        /// <summary>
        /// Create field with options
        /// </summary>
        /// <param name="name">Field`s name</param>
        /// <param name="size">Size of FieldObject array</param>
        /// <param name="objects">Array with FieldObjects</param>
        public Field(string name, Point size, FieldObject[,] objects)
        {
            FieldName = name;
            fieldobjects = objects;
            this.size = size;
        }
    }
}
