using System;
using NMeCab.Specialized;
using MarkovSharp;
using System.Linq;

public class Autowriting
{
    public void Main()
    {
        string[] text = new string[] { };//テキストを入れる

        var model = new StringMarkov(3);
        model.Learn(reversetext(splittext(text)));
        for (int h = 0; h < 5; h++)
        {
            Console.WriteLine(model.Walk().First());
            Console.WriteLine("-----------");
        }
    }

    public string[] splittext(string[] text)
    {
        int i = 0;
        string[] newtext = new string[text.Length];
        using (var tagger = MeCabIpaDicTagger.Create())
        {
            while (text.Length > i)
            {
                newtext[i] = "";
                var nodes = tagger.Parse(text[i]); // 形態素解析を実行
                foreach (var node in nodes) // 形態素ノード配列を順に処理
                {
                    if (String.Compare(node.Surface, "！") == 0 || String.Compare(node.Surface, "。") == 0 || String.Compare(node.Surface, "？") == 0)
                    {
                        newtext[i] += "\n";
                    }
                    else
                    {
                        newtext[i] += node.Surface + " ";
                    }
                }
                i++;
            }
        }
        return newtext;
    }
}