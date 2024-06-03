 class Dragon : GameCharacter
{
    private static Random rand = new Random();
    public Dragon() : base(300, 0, 20) { } //0-50 strength

    public void RandomStrength()
    {
        int newStrength = rand.Next(0, 51);
        EditStrength(newStrength);
    }

}
