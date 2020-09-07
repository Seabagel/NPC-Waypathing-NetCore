namespace NPC_Waypathing_NetCore
{
    enum TypePoint
    {
        Junction,
        Transfer,
        Enterance,
        empty
    }

    interface IPoint
    {

        vector2 vector { get; set; }
        TypePoint type { get; set; }

    }
}
