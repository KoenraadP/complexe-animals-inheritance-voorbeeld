namespace Animals
{
    public class Bird : Animal
    {
        public string[] Colors { get; set; }

        /*public Bird(int averageLifeExpectancy, string[] colors) : base(averageLifeExpectancy)
        {
            Legs = 2;
            CanFly = true;
            AverageLifeExpectancy = averageLifeExpectancy;
            Colors = colors;
        }*/

        public Bird(int legs, bool canFly, int averageLifeExpectancy, string[] colors) : base(legs, canFly, averageLifeExpectancy)
        {
            Colors = colors;
        }

        public string Talk()
        {
            return "Tweet! Tweet!";
        }
    }
}