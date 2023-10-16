using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using MonoMod.Utils;

namespace Celeste.Mod.legendofthemonsterrealm.Objects.Entities
{
    [CustomEntity("legendofthemonsterrealm/CustomMoveBlock")]
    public class CustomMoveBlock : MoveBlock
    {
        private readonly DynamicData BaseData;

        public CustomMoveBlock(EntityData data, Vector2 offset) : base(data, offset)
        {
            BaseData = DynamicData.For(this);
            // other stuff
        }

        public override void Update()
        {
            if (HasPlayerOnTop())
                BaseData.Set("targetSpeed", BaseData.Get<float>("targetSpeed") + 5f);
            base.Update();
        }
    }
}