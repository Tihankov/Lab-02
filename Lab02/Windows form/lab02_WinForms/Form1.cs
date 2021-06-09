using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace lab02_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Max(object mas)
        {
            int[] arr = (int[])mas;
            txtMax.Invoke((MethodInvoker)delegate
            {
                ManipulatePB(pBar1, arr);
            });
            int result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (result < arr[i])
                {
                    result = arr[i];
                }
                txtMax.Invoke((MethodInvoker)delegate { 
                    pBar1.PerformStep();
                });
                Thread.Sleep(100);
            }
            txtMax.Invoke((MethodInvoker)delegate { txtMax.Text = Convert.ToString(result); });
            
        }
        void Avg(object mas)
        {
            int[] arr = (int[])mas;
            txtAvg.Invoke((MethodInvoker)delegate
            {
                ManipulatePB(pBar2, arr);
            });
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                txtAvg.Invoke((MethodInvoker)delegate { pBar2.PerformStep(); });
                Thread.Sleep(200);
            }
            result = result / arr.Length;
            txtAvg.Invoke((MethodInvoker)delegate { txtAvg.Text = Convert.ToString(result); });
        }
        void Min(object mas)
        {
            int[] arr = (int[])mas;
            txtMax.Invoke((MethodInvoker)delegate
            {
                ManipulatePB(pBar3, arr);
            });
            int result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (result > arr[i])
                {
                    result = arr[i];
                }
                txtMin.Invoke((MethodInvoker)delegate { pBar3.PerformStep(); });
                Thread.Sleep(300);
            }
            txtMin.Invoke((MethodInvoker)delegate { txtMin.Text = Convert.ToString(result); });
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            arr = CreateArr();
            if(cbAvg.Checked || cbMax.Checked || cbMin.Checked)
                TextBox(arr);
            Task t1 = new Task(() => Max(arr));
            Task t2 = new Task(() => Avg(arr));
            Task t3 = new Task(() => Min(arr));

            check(t1, cbMax, txtMax, pBar1, arr);
            check(t2, cbAvg, txtAvg, pBar2, arr);
            check(t3, cbMin, txtMin, pBar3, arr);
        }
        void check(Task t1,CheckBox ch,TextBox tx,ProgressBar pr,int []arr)
        {
            if (ch.Checked)
            {
                t1.Start();
            }
            else
            {
                tx.Text = "";
                pr.Value = 0;
            }
        }
        void TextBox(int []arr)
        {

                if (txtArr.Text == "")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        txtArr.Text += Convert.ToString(arr[i]) + " ";
                    }
                }
                else
                {
                    txtArr.Text = "";
                    for (int i = 0; i < arr.Length; i++)
                    {
                        txtArr.Text += Convert.ToString(arr[i]) + " ";
                    }
                }
        }
        void ManipulatePB(ProgressBar pb,int[] arr)   
        {
            pb.Visible = true;
            pb.Value = 0;
            pb.Step = pb.Maximum / arr.Length;
        }
        int[] CreateArr()
        {
            int[] arr = new int[10];
            Random r = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-200, 200);
            }
            return arr;
        }
    }
}
