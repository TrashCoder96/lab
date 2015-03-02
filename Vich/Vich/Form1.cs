using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String key = textBox5.Text;
            int m = key.Length;
            String text = textBox2.Text;
            String alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            Char[] alfchars = alf.ToCharArray();
            List<Char[]> lines = new List<Char[]>();

            foreach (Char c in key.ToCharArray())
            {
                String str = v(alf, c);
                lines.Add(str.ToCharArray());
            }

            Char[] charstext = text.ToCharArray();

            int n = 0;
            for (int i = 0; i < charstext.Length; i++)
            {
                if (alfchars.Contains(charstext[i]))
                {
                    charstext[i] = alfchars[getN(charstext[i], lines[n % m])];
                    n++;
                }
            }

            String s = "";
            for (int i = 0; i < charstext.Length; i++)
            {
                s = s + charstext[i];
            }
            textBox3.Text = s;

        }

        private String v(String s, Char c)
        {
            String[] strings = s.Split(c);
            String newline = c + strings[1] + strings[0];
            return newline;
        }

        private int getN(Char c, Char[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String key = textBox5.Text;
            int m = key.Length;
            String text = textBox1.Text;
            String alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            Char[] alfchars = alf.ToCharArray();
            List<Char[]> lines = new List<Char[]>();

            foreach(Char c in key.ToCharArray())
            {
                String str = v(alf, c);
                lines.Add(str.ToCharArray());
            }

            Char[] charstext = text.ToCharArray();

            int n = 0;
            for(int i = 0; i < charstext.Length; i++)
            {
                if (alfchars.Contains(charstext[i]))
                {
                    charstext[i] = lines[n % m][getN(charstext[i], alfchars)];
                    n++;
                }
            }

            String s = "";
            for(int i = 0; i < charstext.Length; i++)
            {
                s = s + charstext[i];
            }
            textBox2.Text = s;

          
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
