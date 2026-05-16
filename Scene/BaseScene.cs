using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_DxLib_GameTemplate.Scene {
    internal abstract class BaseScene {

        protected string name_;
        protected int sceneCounter_;

        public BaseScene(string name) {
            name_ = name;
            sceneCounter_ = 0;
        }

        public string GetName { get; }

        public abstract void init();
        public abstract void update();
        public abstract void draw();
        public abstract void release();
    }
}
