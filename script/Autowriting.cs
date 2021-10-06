using System;
using NMeCab.Specialized;
using MarkovSharp;
using System.Linq;

public class Autowriting
{
    public void Main()
    {
        string[] text = new string[] { };//�e�L�X�g������

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
                var nodes = tagger.Parse(text[i]); // �`�ԑf��͂����s
                foreach (var node in nodes) // �`�ԑf�m�[�h�z������ɏ���
                {
                    if (String.Compare(node.Surface, "�I") == 0 || String.Compare(node.Surface, "�B") == 0 || String.Compare(node.Surface, "�H") == 0)
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