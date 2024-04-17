namespace Animals
{
    public class Dog : Animal
    {
        public string Breed { get; set; }

        /*public Dog(int averageLifeExpectancy, string breed) : base(averageLifeExpectancy)
        {
            Legs = 4;
            CanFly = false;
            AverageLifeExpectancy = averageLifeExpectancy;
            Breed = breed;
        }*/

        public Dog(int legs, bool canFly, int averageLifeExpectancy, string breed) : base(legs, canFly, averageLifeExpectancy)
        {
            Breed = breed;
        }

        public string Talk()
        {
            return "Woof! Woof!";
        }
    }
}