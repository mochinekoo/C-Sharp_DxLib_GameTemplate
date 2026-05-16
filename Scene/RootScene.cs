using C_Sharp_DxLib_GameTemplate.Object;
using DxLibDLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_DxLib_GameTemplate.Scene {
    using static DX;

    internal class RootScene : BaseScene {

        private TestObject testObject;

        public RootScene() : base("RootScene") {

        }

        public override void init() {
            testObject = new TestObject();
            testObject.init();
        }

        public override void update() {
            testObject.update();
        }

        public override void draw() {
            testObject.draw();
        }

        public override void release() {
            testObject.release();
        }


    }
}
