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

        public override void Update()
        {
            Player player = GetPlayerOnTop();
            if(player!=null&&player.Speed.Y>=0)
            {
                player.Speed = new Vector2(player.Speed.X*2, -50);
            }
            base.Update();
        }
        public override void Render()
        {
            Draw.Rect(Collider, Color.Purple);
        }
    }
}