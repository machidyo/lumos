# lumos
Lumos、Noxの練習ができるアプリです。
杖の振り方、呪文の両方があっていないと光はあなたに訪れません。

## 成功例
https://github.com/machidyo/lumos/assets/1772636/dbfd9b5c-e2bd-4606-95a1-0469cc181f65

# 環境
* Windows10
* Unity2021.2.4f1
* Azure Kinect

## 補足
* UnityEngine.Windows.Speech.DictationRecognizerの制約でWindows11では動きません。
* Unity 2022.3.0f1、2023.2.0f1で実行したときに、マイクのアクセス権限を正常に取得できないときがあった

# 使い方
1. [Azure Kinect DK を設定する](https://learn.microsoft.com/ja-jp/azure/kinect-dk/set-up-azure-kinect-dk)
2. [Body Tracking SDK を設定する](https://learn.microsoft.com/ja-jp/azure/kinect-dk/body-sdk-setup)
3. git clone
4. MoveLibraryFiles.batを実行
5. Unityのバージョンによってはエラーがでるので Assets/Plugins 配下にコピーされる、System.Memory.dllとSystem.Reflection.Emit.Lightweight.dllを削除

## AzureKinectのセットアップの参考手順
[Azure Kinectを使ってUnityでBodyTrackingする](https://qiita.com/matchyy/items/96baf873af33f7a9a3c7)
