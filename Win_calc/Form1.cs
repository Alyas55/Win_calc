﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_calc
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operations_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||operations_pressed)
                result.Clear();

            operations_pressed = false;

            Button b = (Button)sender;
            
            if (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
                result.Text = result.Text + b.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equal.PerformClick();
                operations_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                value = double.Parse(result.Text);
                operations_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = " ";
            operations_pressed = false;

            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;                                       
            }
            value = Int32.Parse(result.Text);
            operation = "";
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                equal.PerformClick();
            }
            else
            {
                switch (e.KeyChar.ToString())
                {
                    case "0":
                        zero.PerformClick();
                        break;
                    case "1":
                        one.PerformClick();
                        break;
                    case "2":
                        two.PerformClick();
                        break;
                    case "3":
                        three.PerformClick();
                        break;
                    case "4":
                        four.PerformClick();
                        break;
                    case "5":
                        five.PerformClick();
                        break;
                    case "6":
                        six.PerformClick();
                        break;
                    case "7":
                        seven.PerformClick();
                        break;
                    case "8":
                        eight.PerformClick();
                        break;
                    case "9":
                        nine.PerformClick();
                        break;
                    case "+":
                        add.PerformClick();
                        break;
                    case "-":
                        sub.PerformClick();
                        break;
                    case "*":
                        times.PerformClick();
                        break;
                    case "/":
                        div.PerformClick();
                        break;
                    case "=":
                        equal.PerformClick();
                        break;
                    case "ENTER":
                        equal.PerformClick();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
