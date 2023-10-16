using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;

namespace Celeste.Mod.legendofthemonsterrealm.Objects.Entities {
    [CustomEntity("legendofthemonsterrealm/SampleSolid")]
    public class SampleSolid : Solid {
        public SampleSolid(EntityData data, Vector2 offset)
            : base(data.Position + offset, data.Width, data.Height, true) {
            myImage = new Image(GFX.Game["objects/legend-of-the-monster-realm-celeste/sampleEntity/idle00"]);
            Add(myImage);
        }
    }
}
