using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        //base64转16进制字符串
        private void baseToHex_Click(object sender, EventArgs e)
        {
            string DataSource = source.Text.Replace("\r", "").Replace("\n","").Replace(" ","");
            try{
                byte[] data = Convert.FromBase64String(DataSource);
                string toHex = BitConverter.ToString(data).Replace("-", string.Empty);
                //MessageBox.Show(hex);
                target.Text = toHex;
            }
            catch (Exception ex) {
               string str  = ex.ToString();
               MessageBox.Show("请输入正确的base64字符!");
            }
            
        }

        //16进制字符串转base64
        private void hexToBase_Click(object sender, EventArgs e)
        {
            string DataSource = source.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            try
            {
                string toBase64 = Convert.ToBase64String(stringToByteArray(DataSource));
                target.Text = toBase64;
            }
            catch (Exception ex)
            {
                string str = ex.ToString();
                MessageBox.Show("数据不能是奇数位!");
            }
             
        }

        //字符串转数组
         private byte[] stringToByteArray(string hexString)  
        {

            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }

        //16进制转10进制
         private void hextodec_Click(object sender, EventArgs e)
         {
            
            string DataSource = source.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            if (DataSource != "")
            {
                try
                {
                    long d = Convert.ToInt64(DataSource, 16);
                    target.Text = d.ToString();
                }

                catch (Exception ex)
                {
                    string str = ex.ToString();
                    MessageBox.Show("输入的数据有误!");
                }
            }
            else
            {
                target.Text = "";
            }
             
         }

        //10进制转16进制
         private void dectohex_Click(object sender, EventArgs e)
         {
            string DataSource = source.Text.Replace("\r", "").Replace("\n", "").Replace(" ", "");
            if (DataSource != ""){
                try{
                long x = long.Parse(DataSource);
                    string hex = Convert.ToString(x, 16);
                    target.Text = hex;
                }
                catch (Exception ex)
                {
                    string str = ex.ToString();
                    MessageBox.Show("输入的数据有误!");
                }
             }
            else
            {
                target.Text = "";
            }
         }

         private void delblank_Click(object sender, EventArgs e)
         {
             try {
                 string DataSource = source.Text;
                 string str = Regex.Replace(DataSource, "[^0-9A-Za-z]", "").Replace("0x","");
                 target.Text = str;
             }
             catch (Exception ex)
             {
                 string str = ex.ToString();
                 MessageBox.Show("输入的数据有误!");
             }
         }

        //字符统计
         private void characternum_Click(object sender, EventArgs e)
         {
             string DataSource = source.Text.Replace("\r", "").Replace("\n", "");
             int charnum = DataSource.Length;
             MessageBox.Show("字符个数:" + charnum);
         }

        //校验和
         private void crcCheck_Click(object sender, EventArgs e)
         {
             string DataSource = source.Text.Replace("\r", "").Replace("\n", "");
             if (DataSource != "")
             {
                 try
                 {
                     string[] res = Form1.Chop(DataSource, 2);
                     int sum = 0;
                     foreach (string ele in res)
                     {
                         int decValue = Convert.ToInt32(ele, 16);
                         sum += decValue;
                     }
                     string strsum = Convert.ToString(sum, 16);
                     string substr = strsum.Substring(strsum.Length - 2, 2);
                     //int crc = Convert.ToInt32(substr, 16); #16进制转10进制long d = Convert.ToInt64(DataSource, 16);
                     target.Text = substr;
                 }
                 catch (Exception ex)
                 {
                     string str = ex.ToString();
                     MessageBox.Show("输入的数据有误!");
                 }
             }
             else
             {
                 target.Text = "";
             }
         }

        //按长度分割字符串
         public static string[] Chop(string value, int length)
         {
             int strLength = value.Length;
             int strCount = (strLength + length - 1) / length;
             string[] result = new string[strCount];
             for (int i = 0; i < strCount; ++i)
             {
                 result[i] = value.Substring(i * length, Math.Min(length, strLength));
                 strLength -= length;
             }
             return result;
         }

        /*
           右键复制粘贴
         */
         private void source_TextChanged(object sender, MouseEventArgs e)
         {
             if (e.Button == System.Windows.Forms.MouseButtons.Right)
             {   //click event
                 //MessageBox.Show("you got it!");
                 ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                 MenuItem menuItem = new MenuItem("Cut");
                 menuItem.Click += new EventHandler(CutAction);
                 contextMenu.MenuItems.Add(menuItem);
                 menuItem = new MenuItem("Copy");
                 menuItem.Click += new EventHandler(CopyAction);
                 contextMenu.MenuItems.Add(menuItem);
                 menuItem = new MenuItem("Paste");
                 menuItem.Click += new EventHandler(PasteAction);
                 contextMenu.MenuItems.Add(menuItem);
                 menuItem = new MenuItem("selectAll");
                 menuItem.Click += new EventHandler(SelectAll);
                 contextMenu.MenuItems.Add(menuItem);

                 source.ContextMenu = contextMenu;
             }
         }

        //剪切
         void CutAction(object sender, EventArgs e)
         {
             source.Cut();
         }

        //复制
         void CopyAction(object sender, EventArgs e)
         {
             Clipboard.SetText(source.SelectedText);
         }

        //粘贴
         void PasteAction(object sender, EventArgs e)
         {
             if (Clipboard.ContainsText())
             {
                 source.Text
                     += Clipboard.GetText(TextDataFormat.Text).ToString();
             }
         }

        //全选
         void SelectAll(object sender, EventArgs e)
         {
             source.SelectAll();
             source.Focus();
         }
    }
}
