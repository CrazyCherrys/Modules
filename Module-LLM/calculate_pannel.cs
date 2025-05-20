using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_LLM
{
    public partial class calculate_pannel : Form
    {

        //基准价格
        double base_price_1K = 0.002;
        double base_price_1M = 2;

        public calculate_pannel()
        {
            InitializeComponent();

            units.Items.Add("1M,即百万Token");
            units.Items.Add("1K，即1K Tokens");
            units.SelectedIndex = 0;

            // 添加 RadioButton 的选择改变事件处理
            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;


        }

        private void RadioButton_CheckedChanged(object sender , EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                if (radioButton == radioButton1)
                {
                    enter_price_title.Text = "官方每单位输入价格 (美元)：";
                    output_price_title.Text = "官方每单位输出价格 (美元)：";
                }
                else if (radioButton == radioButton2) 
                {
                    enter_price_title.Text = "官方每单位输入价格 (人民币)：";
                    output_price_title.Text = "官方每单位输出价格 (人民币)：";
                }

            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            //汇率
            double exchange_rate = 7.3;

            if (radioButton1.Checked)
            {
                if (units.Text.Contains("1M"))
                {
                    //转换输入价格为double类型
                    double input_prices = double.Parse(input_price.Text);
                    //计算倍率
                    double ins = input_prices / base_price_1M;

                    //转换输出价格为double类型
                    double outut_prices = double.Parse(output_price.Text);
                    //计算倍率
                    double outs = outut_prices / input_prices;

                    //修改属性
                    model_ratio.Text = "模型倍率为：" + ins;
                    complete_ratio.Text = "补全倍率为：" + outs;
                }
                else if (units.Text.Contains("1K"))
                {
                    //转换输入价格为double类型
                    double input_prices = double.Parse(input_price.Text);
                    //计算倍率
                    double ins = input_prices / base_price_1K;

                    //转换输出价格为double类型
                    double outut_prices = double.Parse(output_price.Text);
                    //计算倍率
                    double outs = outut_prices / input_prices;

                    //修改属性
                    model_ratio.Text = "模型倍率为：" + ins;
                    complete_ratio.Text = "补全倍率为：" + outs;
                }
            } else if (radioButton2.Checked) 
            {
                if (units.Text.Contains("1M"))
                {
                    //转换输入价格为double类型
                    double input_prices = double.Parse(input_price.Text);
                    //计算倍率
                    double ins = (input_prices / exchange_rate) / base_price_1M;

                    //转换输出价格为double类型
                    double outut_prices = double.Parse(output_price.Text);
                    //计算倍率
                    double outs = outut_prices / input_prices;

                    //修改属性
                    model_ratio.Text = "模型倍率为：" + ins;
                    complete_ratio.Text = "补全倍率为：" + outs;
                }
                else if (units.Text.Contains("1K"))
                {
                    //转换输入价格为double类型
                    double input_prices = double.Parse(input_price.Text);
                    //计算倍率
                    double ins = (input_prices / exchange_rate) / base_price_1K;

                    //转换输出价格为double类型
                    double outut_prices = double.Parse(output_price.Text);
                    //计算倍率
                    double outs = outut_prices / input_prices;

                    //修改属性
                    model_ratio.Text = "模型倍率为：" + ins;
                    complete_ratio.Text = "补全倍率为：" + outs;
                }
            }

        }
    }
}
