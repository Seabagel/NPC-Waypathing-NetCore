namespace NPC_Waypathing_NetCore
{
    class PointJunction : IPoint
    {
        public vector2 vector { get; set; }
        public TypePoint type { get; set; }
        public PointJunction(int x, int y)
        {
            vector = new vector2(x, y);
            this.type = TypePoint.Junction;
        }
    }
}