﻿namespace ATIVIDADE8
{
    partial class frmExercicio5
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
            btnExecutar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(149, 149);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(186, 98);
            btnExecutar.TabIndex = 0;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(460, 35);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(311, 334);
            listBox1.TabIndex = 1;
            // 
            // frmExercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnExecutar);
            Name = "frmExercicio5";
            Text = "frmExercicio5";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExecutar;
        private ListBox listBox1;
    }
}