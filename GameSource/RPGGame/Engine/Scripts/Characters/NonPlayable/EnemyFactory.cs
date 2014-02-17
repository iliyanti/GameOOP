using System.Net.Mail;

namespace RPG.Engine.Scripts.Characters.NonPlayable
{
    public static  class EnemyFactory
    {
        public static Enemy Create()
        {
            Enemy enemy = new AnimalDog(1,1);

            return enemy;
        }
    }
}
