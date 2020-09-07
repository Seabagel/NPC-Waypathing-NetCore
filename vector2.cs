namespace NPC_Waypathing_NetCore
{
    struct vector2
    {
        public int x { get; set; }
        public int y { get; set; }

        public vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsEqual(int x, int y)
        {
            if (x.Equals(this.x) && y.Equals(this.y)) return true;
            else return false;
        }
    }
}
