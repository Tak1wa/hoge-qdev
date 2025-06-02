// 最低限の実装のサンプルコンソールアプリ
// Simple console application with standard input/output

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // 標準出力に "Hello World!" を表示
            Console.WriteLine("Hello World!");
            
            // 標準入力からの読み取りを示すメッセージ
            Console.WriteLine("あなたの名前を入力してください (Please enter your name):");
            
            // 標準入力から名前を読み取る
            string? name = Console.ReadLine();
            
            // 入力された名前を使って挨拶を表示
            Console.WriteLine($"こんにちは、{name}さん！ (Hello, {name}!)");
            
            // キー入力を待つ
            Console.WriteLine("終了するには何かキーを押してください (Press any key to exit)...");
            Console.ReadKey();
        }
    }
}