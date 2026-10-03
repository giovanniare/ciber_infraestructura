namespace HolaMundo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxBase = new TextBox();
            label1 = new Label();
            textBoxConfirmar = new TextBox();
            btnValid = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxBase);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxConfirmar);
            groupBox1.Controls.Add(btnValid);
            groupBox1.Location = new Point(102, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 149);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 10;
            label7.Text = "- Al menos un número";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 129);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 9;
            label6.Text = "- Al menos un símbolo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 109);
            label5.Name = "label5";
            label5.Size = new Size(213, 20);
            label5.TabIndex = 8;
            label5.Text = "- Al menos una letra minúscula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 89);
            label4.Name = "label4";
            label4.Size = new Size(216, 20);
            label4.TabIndex = 7;
            label4.Text = "- Al menos una letra mayúscula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 274);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 6;
            label3.Text = "Confirma la contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 209);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 5;
            label2.Text = "Ingresa la contraseña";
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(116, 232);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.Size = new Size(357, 27);
            textBoxBase.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(151, 23);
            label1.Name = "label1";
            label1.Size = new Size(284, 32);
            label1.TabIndex = 2;
            label1.Text = "Validador de Contraseñas";
            // 
            // textBoxConfirmar
            // 
            textBoxConfirmar.Location = new Point(116, 297);
            textBoxConfirmar.Name = "textBoxConfirmar";
            textBoxConfirmar.Size = new Size(357, 27);
            textBoxConfirmar.TabIndex = 1;
            // 
            // btnValid
            // 
            btnValid.AccessibleName = "";
            btnValid.Location = new Point(208, 351);
            btnValid.Name = "btnValid";
            btnValid.Size = new Size(175, 52);
            btnValid.TabIndex = 0;
            btnValid.Text = "Validar";
            btnValid.UseVisualStyleBackColor = true;
            btnValid.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Validador de contraseñas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxConfirmar;
        private Button btnValid;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBoxBase;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
