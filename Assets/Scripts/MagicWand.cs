using Cysharp.Threading.Tasks;

public static class MagicWand
{
    public static bool CanLumos { get; private set; }
    public static bool CanNox { get; private set; }
    
    public static void CastSpell(string spell)
    {
        if (CanLumos && spell.Contains("ルーモス"))
        {
            PythonRunner.SwitchLight(true);
        }

        // 音声認識がノをナに間違えやすいので、吸収できるようにしておく
        if (CanNox && (spell.Contains("ノックス") || spell.Contains("ナックス")))
        {
            PythonRunner.SwitchLight(false);
        }
    }

    public static async UniTask ReadyLumos()
    {
        if (CanLumos) return;
        
        CanLumos = true;
        await UniTask.Delay(3000);
        CanLumos = false;
    }
    
    public static async UniTask ReadyNox()
    {
        if (CanNox) return;
        
        CanNox = true;
        await UniTask.Delay(3000);
        CanNox = false;
    }
}
