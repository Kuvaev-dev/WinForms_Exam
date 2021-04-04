namespace Tamojka
{
    partial class ThirdCalc
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
            this.cost3 = new System.Windows.Forms.TextBox();
            this.cost2 = new System.Windows.Forms.Label();
            this.calcType3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cost3
            // 
            this.cost3.Location = new System.Drawing.Point(410, 74);
            this.cost3.Name = "cost3";
            this.cost3.Size = new System.Drawing.Size(197, 20);
            this.cost3.TabIndex = 4;
            // 
            // cost2
            // 
            this.cost2.AutoSize = true;
            this.cost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost2.Location = new System.Drawing.Point(170, 72);
            this.cost2.Name = "cost2";
            this.cost2.Size = new System.Drawing.Size(194, 20);
            this.cost2.TabIndex = 3;
            this.cost2.Text = "Стоимость автомобиля:";
            // 
            // calcType3
            // 
            this.calcType3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcType3.Location = new System.Drawing.Point(323, 123);
            this.calcType3.Name = "calcType3";
            this.calcType3.Size = new System.Drawing.Size(126, 49);
            this.calcType3.TabIndex = 10;
            this.calcType3.Text = "Рассчитать";
            this.calcType3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(171, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Стоимость растаможки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(406, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "label3";
            // 
            // ThirdCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcType3);
            this.Controls.Add(this.cost3);
            this.Controls.Add(this.cost2);
            this.Name = "ThirdCalc";
            this.Text = "ThirdCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cost3;
        private System.Windows.Forms.Label cost2;
        private System.Windows.Forms.Button calcType3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}