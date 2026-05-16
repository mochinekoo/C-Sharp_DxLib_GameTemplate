using DxLibDLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_DxLib_GameTemplate.Scene {
    using static DX;

    internal class RootScene : BaseScene {

        public RootScene() : base("RootScene") {

        }

        public override void init() {

        }

        public override void update() {

        }

        public override void draw() {
            DrawString(0, 0, "Draw", GetColor(255, 255, 255));
        }

        public override void release() {

        }


    }
}
