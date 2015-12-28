namespace EnvironmentSystem.Models.Objects
{
    using System;
    using System.Collections.Generic;

    public class StaticStar : EnvironmentObject
    {
        private const int ImageChangeFrequency = 10;

        protected static readonly char[] StarImages = new char[] { 'O', '@', '0' };
        private static readonly Random ImageRandom = new Random();

        private int updatesCount;

        public StaticStar(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
            this.ImageProfile = new char[,] { { StarImages[0] } };
        }

        public override void Update()
        {
            if (this.updatesCount % ImageChangeFrequency == 0)
            {
                int index = ImageRandom.Next(0, StarImages.Length);
                this.ImageProfile = new char[,] { { StarImages[index] } };
            }

            this.updatesCount++;
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            if (collisionInfo.HitObject.CollisionGroup == CollisionGroup.Explosion)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new EnvironmentObject[0];
        }
    }
}
