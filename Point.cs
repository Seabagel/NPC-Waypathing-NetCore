namespace NPC_Waypathing_NetCore
{
    struct Point
    {
        public vector2 vector { get; set; }
        public bool isPoint { get; set; }
        public Point(int x, int y)
        {
            vector = new vector2(x, y);
            isPoint = false;
        }
    }
}
