namespace StickyNotesDesktop
{
    partial class Form1
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
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.plus_button = new System.Windows.Forms.PictureBox();
            this.trash_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.plus_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash_button)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.AcceptsTab = true;
            this.mainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTextBox.EnableAutoDragDrop = true;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTextBox.Location = new System.Drawing.Point(12, 60);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(256, 318);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.Text = "";
            this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
            // 
            // plus_button
            // 
            this.plus_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plus_button.Image = global::StickyNotesDesktop.Properties.Resources.plusButton;
            this.plus_button.Location = new System.Drawing.Point(178, 12);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(42, 42);
            this.plus_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plus_button.TabIndex = 1;
            this.plus_button.TabStop = false;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // trash_button
            // 
            this.trash_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trash_button.Image = global::StickyNotesDesktop.Properties.Resources.trashButton;
            this.trash_button.Location = new System.Drawing.Point(226, 12);
            this.trash_button.Name = "trash_button";
            this.trash_button.Size = new System.Drawing.Size(42, 42);
            this.trash_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trash_button.TabIndex = 0;
            this.trash_button.TabStop = false;
            this.trash_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trash_button_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(280, 390);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.trash_button);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(280, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(280, 390);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Sticky Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.plus_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trash_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trash_button;
        private System.Windows.Forms.PictureBox plus_button;
        private System.Windows.Forms.RichTextBox mainTextBox;
    }
}

