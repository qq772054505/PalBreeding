namespace PalBreeding
{
    public enum Gender
    {
        Male = 1,
        Female = 2,
    }
    internal class Palu
    {
        public required int No { get; set; }
        public required string Name { get; set; }
    }
    internal class PaluIndividual:Palu
    {
        public required string Description { get; set; }
        public required Gender Gender { get; set; }
    }

}
