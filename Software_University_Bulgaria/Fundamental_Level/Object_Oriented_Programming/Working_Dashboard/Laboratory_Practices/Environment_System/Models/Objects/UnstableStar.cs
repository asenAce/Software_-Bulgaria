namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    public class UnstableStar : FallingStar
    {
        private int lifetime;

        public UnstableStar(int x, int y, int width, int height, Point direction, int lifetime = 10)
            : base(x, y, width, height, direction)
        {
            this.lifetime = lifetime;
        }

        public override void Update()
        {
            if (this.lifetime <= 0)
            {
                this.Exists = false;
            }

            this.lifetime--;
            base.Update();
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> producedObjects = new List<EnvironmentObject>();
            if (!this.Exists)
            {
                for (int y = this.Bounds.TopLeft.Y - 2; y <= this.Bounds.TopLeft.Y + 2; y++)
                {
                    for (int x = this.Bounds.TopLeft.X - 2; x <= this.Bounds.TopLeft.X + 2; x++)
                    {
                        if (!(x == this.Bounds.TopLeft.X && y == this.Bounds.TopLeft.Y))
                        {
                            producedObjects.Add(new Explosion(x, y, 2));
                        }
                    }
                }

                return producedObjects;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
