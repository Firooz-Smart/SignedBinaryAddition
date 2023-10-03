using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signed_Binary_Addition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {
                if (MyClass.isValidate(txt1.Text) && MyClass.isValidate(txt2.Text))
                {
                    lblerror.Text = "";
                    String fn = txt1.Text;
                    char fnsign = txt1.Text[0] == '0' ? '+' : '-';
                    String temp = "";
                    temp = "";
                    for (int i = txt1.Text.Length - 1; i > 0; --i)
                    {
                        temp += txt1.Text[i];
                    }
                    fn = "";
                    for (int i = temp.Length - 1; i >= 0; --i)
                    {
                        fn += temp[i];
                    }


                    String sn = txt2.Text;

                    char snsign = txt2.Text[0] == '0' ? '+' : '-';
                    String tem = "";
                    temp = "";
                    for (int j = txt2.Text.Length - 1; j > 0; --j)
                    {
                        tem += txt2.Text[j];
                    }
                    sn = "";
                    for (int i = tem.Length - 1; i >= 0; --i)
                    {
                        sn += tem[i];
                    }
                    long fni = MyClass.toDecimal(long.Parse(fn), 2);
                    long sni = MyClass.toDecimal(long.Parse(sn), 2);
                    if (fnsign == '-')
                        fni = -fni;

                    if (snsign == '-')
                        sni = -sni;

                    long result = (fni + sni);
                    char resultsign = result < 0 ? '-' : '+';
                    result = Math.Abs(result);
                    String binaryResult = Convert.ToString(result, 2);
                    if (resultsign == '-')
                    {
                        binaryResult = "1" + binaryResult;
                    }
                    else
                        binaryResult = "0" + binaryResult;


                    txtresult.Text = binaryResult;
                }
                else
                {
                    txtresult.Text = "";
                    lblerror.Text = "Input is not binary !";
                }
            }
            else
            {
                lblerror.Text = "Please input binary digits.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (txt1.Text != "" && txt2.Text != "")
            {
                if (MyClass.isValidate(txt1.Text) && MyClass.isValidate(txt2.Text))
                {
                    lblerror.Text = "";
                    String fn = txt1.Text;
                    char fnsign = txt1.Text[0] == '0' ? '+' : '-';
                    String temp = "";
                    temp = "";
                    for (int i = txt1.Text.Length - 1; i > 0; --i)
                    {
                        temp += txt1.Text[i];
                    }
                    fn = "";
                    for (int i = temp.Length - 1; i >= 0; --i)
                    {
                        fn += temp[i];
                    }


                    String sn = txt2.Text;

                    char snsign = txt2.Text[0] == '0' ? '+' : '-';
                    String tem = "";
                    temp = "";
                    for (int j = txt2.Text.Length - 1; j > 0; --j)
                    {
                        tem += txt2.Text[j];
                    }
                    sn = "";
                    for (int i = tem.Length - 1; i >= 0; --i)
                    {
                        sn += tem[i];
                    }
                    long fni = MyClass.toDecimal(long.Parse(fn), 2);
                    long sni = MyClass.toDecimal(long.Parse(sn), 2);
                    if (fnsign == '-')
                        fni = -fni;

                    if (snsign == '-')
                        sni = -sni;

                    long result = (fni - sni);
                    char resultsign = result < 0 ? '-' : '+';
                    result = Math.Abs(result);
                    String binaryResult = Convert.ToString(result, 2);
                    if (resultsign == '-')
                    {
                        binaryResult = "1" + binaryResult;
                    }
                    else
                        binaryResult = "0" + binaryResult;


                    txtresult.Text = binaryResult;
                }
                else
                {
                    txtresult.Text = "";
                    lblerror.Text = "Input is not binary !";
                }

            }else
            {
                lblerror.Text = "Please input binary digits.";
            }
        }
    }
}
