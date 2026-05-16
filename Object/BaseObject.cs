using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_DxLib_GameTemplate.Object {
    internal abstract class BaseObject {

        protected string name_;
        protected bool isAlive_;

        public BaseObject(string name, bool isAlive) {
            name_ = name;
            isAlive_ = isAlive;
        }

        public abstract void init();
        public abstract void update();
        public abstract void draw();
        public abstract void release();
    }
}
