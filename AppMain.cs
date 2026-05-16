
using System.Runtime.InteropServices.Marshalling;

namespace CSharp_DxLib_GameTemplate {
    using C_Sharp_DxLib_GameTemplate;
    using C_Sharp_DxLib_GameTemplate.Manager;
    using C_Sharp_DxLib_GameTemplate.Scene;
    using System.Diagnostics;
    using static DxLibDLL.DX;

    class AppMain {

        public static void Main() {
            if (InitApp() == -1) {
                ReleaseApp();
                throw new InvalidOperationException("ゲームの初期化に失敗しました。");             
            }

            while (ProcessMessage() == 0) {
                ClearDrawScreen();

                BaseScene currentScene = SceneManager.GetInstance.GetCurrentScene();
                if (currentScene != null) {
                    currentScene.update();
                    currentScene.draw();
                }

                ScreenFlip();
            }

            ReleaseApp();
        }

        public static int InitApp() {
            SetMainWindowText(Framework.TITLE);
            ChangeFontType(DX_FONTTYPE_ANTIALIASING_16X16);
            ChangeWindowMode(TRUE);
            SetGraphMode(Framework.WIDTH, Framework.HEIGHT, Framework.COLORBIT); //画面の設定
            SetWindowSizeChangeEnableFlag(FALSE); //ウインドウのサイズ変更
            SetAlwaysRunFlag(TRUE); //ウインドウがアクティブじゃなくても実行
            SetUseZBuffer3D(TRUE); //Zバッファを使用する
            SetWriteZBuffer3D(TRUE); //Zバッファに書き込む
            SetUseDirect3DVersion(DX_DIRECT3D_11); //HLSLを使用するための、DirectX
            if (DxLib_Init() == -1) {
                return -1;
            }
            SetBackgroundColor(Framework.BACKGROUND[0], Framework.BACKGROUND[1], Framework.BACKGROUND[2]);
            SetDrawScreen(DX_SCREEN_BACK);

            SceneManager.GetInstance.InitManager();
            return 0;
        }

        public static void ReleaseApp() {
            DxLib_End();
        }

    }
}