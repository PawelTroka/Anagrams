namespace Anagrams
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deserializeButton = new System.Windows.Forms.Button();
            this.serializeButton = new System.Windows.Forms.Button();
            this.analyseButton = new System.Windows.Forms.Button();
            this.encryptCheckBox = new System.Windows.Forms.CheckBox();
            this.compressCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(52, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(834, 394);
            this.listBox1.TabIndex = 0;
            // 
            // deserializeButton
            // 
            this.deserializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deserializeButton.Location = new System.Drawing.Point(892, 297);
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(167, 127);
            this.deserializeButton.TabIndex = 1;
            this.deserializeButton.Text = "Deserialize";
            this.deserializeButton.UseVisualStyleBackColor = true;
            this.deserializeButton.Click += new System.EventHandler(this.deserializeButton_Click);
            // 
            // serializeButton
            // 
            this.serializeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serializeButton.Location = new System.Drawing.Point(892, 164);
            this.serializeButton.Name = "serializeButton";
            this.serializeButton.Size = new System.Drawing.Size(167, 127);
            this.serializeButton.TabIndex = 2;
            this.serializeButton.Text = "Serialize";
            this.serializeButton.UseVisualStyleBackColor = true;
            this.serializeButton.Click += new System.EventHandler(this.serializeButton_Click);
            // 
            // analyseButton
            // 
            this.analyseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.analyseButton.Location = new System.Drawing.Point(892, 31);
            this.analyseButton.Name = "analyseButton";
            this.analyseButton.Size = new System.Drawing.Size(167, 127);
            this.analyseButton.TabIndex = 3;
            this.analyseButton.Text = "Analyze";
            this.analyseButton.UseVisualStyleBackColor = true;
            this.analyseButton.Click += new System.EventHandler(this.analyseButton_Click);
            // 
            // encryptCheckBox
            // 
            this.encryptCheckBox.AutoSize = true;
            this.encryptCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encryptCheckBox.Location = new System.Drawing.Point(1065, 193);
            this.encryptCheckBox.Name = "encryptCheckBox";
            this.encryptCheckBox.Size = new System.Drawing.Size(94, 29);
            this.encryptCheckBox.TabIndex = 4;
            this.encryptCheckBox.Text = "encrypt";
            this.encryptCheckBox.UseVisualStyleBackColor = true;
            // 
            // compressCheckBox
            // 
            this.compressCheckBox.AutoSize = true;
            this.compressCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.compressCheckBox.Location = new System.Drawing.Point(1065, 228);
            this.compressCheckBox.Name = "compressCheckBox";
            this.compressCheckBox.Size = new System.Drawing.Size(130, 29);
            this.compressCheckBox.TabIndex = 5;
            this.compressCheckBox.Text = "compress";
            this.compressCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 607);
            this.Controls.Add(this.compressCheckBox);
            this.Controls.Add(this.encryptCheckBox);
            this.Controls.Add(this.analyseButton);
            this.Controls.Add(this.serializeButton);
            this.Controls.Add(this.deserializeButton);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deserializeButton;
        private System.Windows.Forms.Button serializeButton;
        private System.Windows.Forms.Button analyseButton;
        private System.Windows.Forms.CheckBox encryptCheckBox;
        private System.Windows.Forms.CheckBox compressCheckBox;
    }
}

