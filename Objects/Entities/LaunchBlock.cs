using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;
using MonoMod.Utils;

namespace Celeste.Mod.legendofthemonsterrealm.Objects.Entities
{
    [CustomEntity("legendofthemonsterrealm/LaunchBlock")]
    public class LaunchBlock : Solid
    {
        private readonly DynamicData BaseData;
        public LaunchBlock(EntityData data, Vector2 offset) : base(data.Position + offset, data.Width,data.Height,false)
        {
            BaseData = DynamicData.For(this);
            // other stuff
        }
        public float sign(float inty)
        {
            if (inty > 0)
            {
                inty = 1;
            }
            if (inty < 0)
            {
                inty = -1;
            }
            return inty;
        }
        public override void Update()
        {
            Player player = GetPlayerOnTop();
            if(player!=null)
            {
                player.Speed.X += player.Speed.X/4;
            }
            Player player2 = GetPlayerClimbing();
            if (player2 != null)
            {
                player2.Speed.Y += player2.Speed.Y/2;
            }
            base.Update();
        }
        public override void Render()
        {
            Draw.Rect(Collider, Color.Purple);
        }
    }
}