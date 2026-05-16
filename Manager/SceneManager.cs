using C_Sharp_DxLib_GameTemplate.Scene;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_DxLib_GameTemplate.Manager {
    internal class SceneManager {

        public static SceneManager GetInstance { get; } = new SceneManager();
        private Dictionary<string, BaseScene> sceneMap;
        private BaseScene currentScene_;

        private SceneManager() {
            sceneMap = new Dictionary<string, BaseScene>();
        }

        public void InitManager() {
            sceneMap.Clear();
            sceneMap.Add("RootScene", SceneFactory.CreateRootScene());

            ChangeScene("RootScene");
        }

        public void ReleaseManager() {

        }

        public int ChangeScene(string name) {
            var scene = GetScene(name);
            if (scene != null) {
                currentScene_ = scene;
                currentScene_.init();
                return 0;
            }
            return -1;
        }

        public BaseScene GetCurrentScene() {
            return currentScene_;
        }

        public BaseScene GetScene(string name) {
            if (sceneMap.TryGetValue(name, out BaseScene? value)) {
                return value;
            }
            return null;
        }
    }

    internal class SceneFactory {

        public static RootScene CreateRootScene() {
            return new RootScene();
        }
    }
}
