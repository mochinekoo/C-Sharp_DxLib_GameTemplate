using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_DxLib_GameTemplate.Object {
    using static DxLibDLL.DX;

    internal class TestObject : BaseObject {

        public TestObject() : base("TestObject", true) {

        }

        public override void init() {

        }

        public override void update() {

        }

        public override void draw() {
            DrawCircle(500, 500, 10, GetColor(255, 0, 0));
        }

        public override void release() {

        }
    }
}
