namespace WinFormsTabla
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
            PanelPrincipal = new Panel();
            label1 = new Label();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labelTitulo = new Label();
            PanelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = SystemColors.ActiveCaption;
            PanelPrincipal.Controls.Add(label1);
            PanelPrincipal.Controls.Add(richTextBoxResultados);
            PanelPrincipal.Controls.Add(buttonVer);
            PanelPrincipal.Controls.Add(textBoxNum);
            PanelPrincipal.Controls.Add(labelNumero);
            PanelPrincipal.Controls.Add(labelTitulo);
            PanelPrincipal.Location = new Point(8, 9);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(693, 433);
            PanelPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 32);
            label1.TabIndex = 5;
            label1.Text = "Jessica Yasmin Trinidad Delgado";
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Segoe UI Symbol", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBoxResultados.ForeColor = SystemColors.ActiveCaptionText;
            richTextBoxResultados.Location = new Point(344, 114);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(179, 269);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            richTextBoxResultados.TextChanged += richTextBoxResultados_TextChanged;
            // 
            // buttonVer
            // 
            buttonVer.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVer.Location = new Point(194, 149);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(112, 34);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver Tabla";
            buttonVer.UseVisualStyleBackColor = true;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = Color.White;
            textBoxNum.Location = new Point(20, 151);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.RightToLeft = RightToLeft.No;
            textBoxNum.Size = new Size(150, 31);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNumero.Location = new Point(20, 114);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(218, 20);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "Cual tabla quieres?";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(229, 42);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(253, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Tag = " ";
            labelTitulo.Text = "Tabla de Multiplicar ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(PanelPrincipal);
            Name = "Form1";
            Text = "Form1";
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPrincipal;
        private Label labelTitulo;
        private Label labelNumero;
        private TextBox textBoxNum;
        private RichTextBox richTextBoxResultados;
        private Button buttonVer;
        private Label label1;
    }
}
