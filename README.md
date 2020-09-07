# NPC-Waypathing-NetCore
 2D movement using 1 Dimensional pathfinding

### How to run:
- Install .NetCore 3.1 SDK from [dotnet.Microsoft.com](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- clone repository
- open directory in cmd or psh
- dotnet run

## Idea
- Instead of using pathfinding, use direction and speed until the object's (x,y) equals the goal point

### To-do:
- [ ] Create an Waypath class that keeps a list of points
- [ ] Add Direction enum, int MovementSpeed, enum nextWaypoint <vector2>, into Waypath class
- [ ] in Waypath, OnCollision() = On collision with a point, do one of 3 things:
    - Junction : Change direction and nextWaypoint
    - Transfer : Put NPC in another location, and keeps moving to the next available point
    - Enter    : NPC enters a building, stops the Wayfinding, and set the NPC's
                 direction and (x,y) inside the building
- [ ] in Waypath, Move() =
    - Move NPC at MoveSpeed every second
    - Towards an enum Direction
    - Until (x,y) equals nextPoint's (x,y)
    - Then, trigger OnCollision
