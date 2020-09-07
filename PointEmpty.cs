namespace NPC_Waypathing_NetCore
{
    class PointEmpty : IPoint
    {
        public vector2 vector { get; set; }
        public TypePoint type { get; set; }
        public PointEmpty(int x, int y)
        {
            vector = new vector2(x, y);
            this.type = TypePoint.empty;
        }
    }
}