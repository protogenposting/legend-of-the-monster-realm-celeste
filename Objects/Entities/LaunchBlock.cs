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
        Player player;
        public LaunchBlock(EntityData data, Vector2 offset) : base(data.Position + offset, data.Width,data.Height,false)
        {
            BaseData = DynamicData.For(this);
            // other stuff
        }
        public float sign(float inty)
        {
            if(inty>0)
            {
                inty = 1;
            }
            if (inty < 0)
            {
                inty = -1;
            }
            if (inty == 0)
            {
                inty = 0;
            }
            return inty;
        }
        public override void Update()
        {
            player = GetPlayerOnTop();
            if(player!=null && player.CanDash)
            {
                player.Speed.X += sign(player.Speed.X);
                //player.Position.Y -= 1;
            }
            player = GetPlayerClimbing();
            if (player != null && player.CanDash)
            {
                player.Speed.Y += sign(player.Speed.Y);
                //player.Position.Y -= 1;
            }
            base.Update();
        }
        public override void Render()
        {
            Draw.Rect(Collider, Color.Purple);
        }
    }
}