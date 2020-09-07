namespace NPC_Waypathing_NetCore
{
    class PointEnterance : IPoint
    {
        public vector2 vector { get; set; }
        public TypePoint type { get; set; }
        public PointEnterance(int x, int y)
        {
            vector = new vector2(x, y);
            this.type = TypePoint.Enterance;
        }
    }
}