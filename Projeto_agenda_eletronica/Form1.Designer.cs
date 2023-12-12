namespace Projeto_agenda_eletronica
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            emailtextbox = new TextBox();
            cpftextbox = new TextBox();
            telefonetextbox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 166);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 219);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 114);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefone";
            // 
            // emailtextbox
            // 
            emailtextbox.Location = new Point(263, 159);
            emailtextbox.Name = "emailtextbox";
            emailtextbox.Size = new Size(308, 27);
            emailtextbox.TabIndex = 3;
            // 
            // cpftextbox
            // 
            cpftextbox.Location = new Point(263, 212);
            cpftextbox.Name = "cpftextbox";
            cpftextbox.Size = new Size(308, 27);
            cpftextbox.TabIndex = 4;
            // 
            // telefonetextbox
            // 
            telefonetextbox.Location = new Point(263, 107);
            telefonetextbox.Name = "telefonetextbox";
            telefonetextbox.Size = new Size(308, 27);
            telefonetextbox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(454, 297);
            button1.Name = "button1";
            button1.Size = new Size(145, 45);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(247, 297);
            button2.Name = "button2";
            button2.Size = new Size(145, 45);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(telefonetextbox);
            Controls.Add(cpftextbox);
            Controls.Add(emailtextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Agenda Eletronica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emailtextbox;
        private TextBox cpftextbox;
        private TextBox telefonetextbox;
        private Button button1;
        private Button button2;
    }
}