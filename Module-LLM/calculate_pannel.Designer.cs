
namespace Module_LLM
{
    partial class calculate_pannel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter_price_title = new System.Windows.Forms.Label();
            this.output_price_title = new System.Windows.Forms.Label();
            this.input_price = new System.Windows.Forms.TextBox();
            this.output_price = new System.Windows.Forms.TextBox();
            this.unit_title = new System.Windows.Forms.Label();
            this.units = new System.Windows.Forms.ComboBox();
            this.model_ratio = new System.Windows.Forms.Label();
            this.complete_ratio = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // enter_price_title
            // 
            this.enter_price_title.AutoSize = true;
            this.enter_price_title.Location = new System.Drawing.Point(116, 75);
            this.enter_price_title.Name = "enter_price_title";
            this.enter_price_title.Size = new System.Drawing.Size(251, 18);
            this.enter_price_title.TabIndex = 0;
            this.enter_price_title.Text = "官方每单位输入价格 (美元)：";
            // 
            // output_price_title
            // 
            this.output_price_title.AutoSize = true;
            this.output_price_title.Location = new System.Drawing.Point(116, 123);
            this.output_price_title.Name = "output_price_title";
            this.output_price_title.Size = new System.Drawing.Size(251, 18);
            this.output_price_title.TabIndex = 1;
            this.output_price_title.Text = "官方每单位输出价格 (美元)：";
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(422, 65);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(252, 28);
            this.input_price.TabIndex = 2;
            // 
            // output_price
            // 
            this.output_price.Location = new System.Drawing.Point(422, 123);
            this.output_price.Name = "output_price";
            this.output_price.Size = new System.Drawing.Size(252, 28);
            this.output_price.TabIndex = 3;
            // 
            // unit_title
            // 
            this.unit_title.AutoSize = true;
            this.unit_title.Location = new System.Drawing.Point(116, 190);
            this.unit_title.Name = "unit_title";
            this.unit_title.Size = new System.Drawing.Size(53, 18);
            this.unit_title.TabIndex = 4;
            this.unit_title.Text = "单位:";
            // 
            // units
            // 
            this.units.AutoCompleteCustomSource.AddRange(new string[] {
            "百万Tokens（即1M）",
            "1K Tokens"});
            this.units.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.units.FormattingEnabled = true;
            this.units.Location = new System.Drawing.Point(422, 190);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(252, 26);
            this.units.TabIndex = 5;
            // 
            // model_ratio
            // 
            this.model_ratio.AutoSize = true;
            this.model_ratio.Location = new System.Drawing.Point(116, 257);
            this.model_ratio.Name = "model_ratio";
            this.model_ratio.Size = new System.Drawing.Size(116, 18);
            this.model_ratio.TabIndex = 6;
            this.model_ratio.Text = "模型倍率为：";
            // 
            // complete_ratio
            // 
            this.complete_ratio.AutoSize = true;
            this.complete_ratio.Location = new System.Drawing.Point(419, 257);
            this.complete_ratio.Name = "complete_ratio";
            this.complete_ratio.Size = new System.Drawing.Size(107, 18);
            this.complete_ratio.TabIndex = 7;
            this.complete_ratio.Text = "补全倍率为:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(335, 362);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(145, 58);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "计算倍率";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(203, 312);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 22);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "美元(USD)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(454, 312);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 22);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "人民币(CNY)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // calculate_pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.complete_ratio);
            this.Controls.Add(this.model_ratio);
            this.Controls.Add(this.units);
            this.Controls.Add(this.unit_title);
            this.Controls.Add(this.output_price);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.output_price_title);
            this.Controls.Add(this.enter_price_title);
            this.Name = "calculate_pannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculate_pannel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enter_price_title;
        private System.Windows.Forms.Label output_price_title;
        private System.Windows.Forms.TextBox input_price;
        private System.Windows.Forms.TextBox output_price;
        private System.Windows.Forms.Label unit_title;
        private System.Windows.Forms.ComboBox units;
        private System.Windows.Forms.Label model_ratio;
        private System.Windows.Forms.Label complete_ratio;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}