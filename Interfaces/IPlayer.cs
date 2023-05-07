using CSharpExamples.OOP;

namespace CSharpExamples.Interfaces
{
    public interface IPlayer
    {
        void FindEnemiesInCloseProximity(int enemies = 3);

        public bool MovePlayer(Vector3 newPosition);
    }
}
