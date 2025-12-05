using PhysicsLibrary;
using BiologyLibrary;
using ChemistryLibrary;

namespace ScienceLibrary
{
    public class Science
    {
        public Object GetScienceField()
        {
            Physics physics = new Physics();
            Biology biology = new Biology();
            Chemistry chemistry = new Chemistry();

            Object [] fields = { "Science has : ", physics.GetField(), biology.GetField(), chemistry.GetField() };
            return fields;
        }
    }
}
