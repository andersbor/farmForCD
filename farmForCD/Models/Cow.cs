namespace farmForCD.Models
{
    public class Cow
    {
        public int MyProperty { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            if (Name.Length < 3)
            {
                throw new ArgumentException("Name must be at least 3 characters long: " + Name);
            }
        }

        override
        public string ToString()
        {
            return $"Cow: {Name} weighs {Weight} pounds.";
        }
    }
}
