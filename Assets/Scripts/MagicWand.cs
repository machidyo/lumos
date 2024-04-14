public static class MagicWand
{
    public static void CastSpell(string spell)
    {
        if (spell.Contains("ルーモス"))
        {
            PythonRunner.SwitchLight(true);
        }

        // 音声認識がノをナに間違えやすいので、吸収できるようにしておく
        if (spell.Contains("ノックス") || spell.Contains("ナックス"))
        {
            PythonRunner.SwitchLight(false);
        }
    }
}
