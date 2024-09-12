namespace ErosionLunar.Prototipos.Ejercicio01.DatosDeUnaPersona
{
    partial class DatosDeUnaPersonaForm
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
            label1 = new Label();
            NombreText = new TextBox();
            ApellidoText = new TextBox();
            label2 = new Label();
            DNIText = new TextBox();
            label3 = new Label();
            FechaNacText = new TextBox();
            label4 = new Label();
            AceptarButton = new Button();
            FinalizarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // NombreText
            // 
            NombreText.Location = new Point(19, 36);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(263, 27);
            NombreText.TabIndex = 1;
            // 
            // ApellidoText
            // 
            ApellidoText.Location = new Point(288, 36);
            ApellidoText.Name = "ApellidoText";
            ApellidoText.Size = new Size(251, 27);
            ApellidoText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // DNIText
            // 
            DNIText.Location = new Point(19, 91);
            DNIText.Name = "DNIText";
            DNIText.Size = new Size(323, 27);
            DNIText.TabIndex = 5;
            DNIText.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 64);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            label3.Click += label3_Click;
            // 
            // FechaNacText
            // 
            FechaNacText.Location = new Point(348, 91);
            FechaNacText.Name = "FechaNacText";
            FechaNacText.Size = new Size(191, 27);
            FechaNacText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 66);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha Nacimiento";
            // 
            // AceptarButton
            // 
            AceptarButton.Location = new Point(345, 141);
            AceptarButton.Name = "AceptarButton";
            AceptarButton.Size = new Size(94, 29);
            AceptarButton.TabIndex = 8;
            AceptarButton.Text = "Aceptar";
            AceptarButton.UseVisualStyleBackColor = true;
            AceptarButton.Click += AceptarButton_Click;
            // 
            // FinalizarButton
            // 
            FinalizarButton.Location = new Point(445, 141);
            FinalizarButton.Name = "FinalizarButton";
            FinalizarButton.Size = new Size(94, 29);
            FinalizarButton.TabIndex = 9;
            FinalizarButton.Text = "Finalizar";
            FinalizarButton.UseVisualStyleBackColor = true;
            // 
            // DatosDeUnaPersonaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 182);
            Controls.Add(FinalizarButton);
            Controls.Add(AceptarButton);
            Controls.Add(FechaNacText);
            Controls.Add(label4);
            Controls.Add(DNIText);
            Controls.Add(label3);
            Controls.Add(ApellidoText);
            Controls.Add(label2);
            Controls.Add(NombreText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DatosDeUnaPersonaForm";
            Text = "DatosDeUnaPersonaForm";
            Load += DatosDeUnaPersonaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NombreText;
        private TextBox ApellidoText;
        private Label label2;
        private TextBox DNIText;
        private Label label3;
        private TextBox FechaNacText;
        private Label label4;
        private Button AceptarButton;
        private Button FinalizarButton;
    }
}