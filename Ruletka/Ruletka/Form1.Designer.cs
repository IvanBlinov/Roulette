namespace Ruletka
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGO = new System.Windows.Forms.Button();
            this.labelCurrentAccount = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxRed = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlack = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreen = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelWin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(369, 240);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(163, 72);
            this.buttonGO.TabIndex = 0;
            this.buttonGO.Text = "КРУТИТЬ";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // labelCurrentAccount
            // 
            this.labelCurrentAccount.AutoSize = true;
            this.labelCurrentAccount.Location = new System.Drawing.Point(12, 33);
            this.labelCurrentAccount.Name = "labelCurrentAccount";
            this.labelCurrentAccount.Size = new System.Drawing.Size(80, 13);
            this.labelCurrentAccount.TabIndex = 1;
            this.labelCurrentAccount.Text = "Текущий счет:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(399, 193);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(49, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Выпало:";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(30, 295);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(48, 13);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Ставим:";
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(12, 189);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(68, 17);
            this.radioButtonRed.TabIndex = 4;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Красное";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(118, 189);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(63, 17);
            this.radioButtonBlack.TabIndex = 5;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Черное";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(227, 189);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(68, 17);
            this.radioButtonGreen.TabIndex = 6;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Зеленое";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "black.jpg");
            this.imageList.Images.SetKeyName(1, "red.jpg");
            this.imageList.Images.SetKeyName(2, "green.jpg");
            // 
            // pictureBoxRed
            // 
            this.pictureBoxRed.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRed.Image")));
            this.pictureBoxRed.Location = new System.Drawing.Point(12, 94);
            this.pictureBoxRed.Name = "pictureBoxRed";
            this.pictureBoxRed.Size = new System.Drawing.Size(82, 63);
            this.pictureBoxRed.TabIndex = 8;
            this.pictureBoxRed.TabStop = false;
            // 
            // pictureBoxBlack
            // 
            this.pictureBoxBlack.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlack.Image")));
            this.pictureBoxBlack.Location = new System.Drawing.Point(118, 94);
            this.pictureBoxBlack.Name = "pictureBoxBlack";
            this.pictureBoxBlack.Size = new System.Drawing.Size(82, 63);
            this.pictureBoxBlack.TabIndex = 9;
            this.pictureBoxBlack.TabStop = false;
            // 
            // pictureBoxGreen
            // 
            this.pictureBoxGreen.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreen.Image")));
            this.pictureBoxGreen.Location = new System.Drawing.Point(227, 94);
            this.pictureBoxGreen.Name = "pictureBoxGreen";
            this.pictureBoxGreen.Size = new System.Drawing.Size(82, 63);
            this.pictureBoxGreen.TabIndex = 10;
            this.pictureBoxGreen.TabStop = false;
            // 
            // pictureBoxResult
            // 
            this.pictureBoxResult.Location = new System.Drawing.Point(402, 39);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(130, 118);
            this.pictureBoxResult.TabIndex = 11;
            this.pictureBoxResult.TabStop = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(84, 292);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(124, 20);
            this.textBoxInput.TabIndex = 12;
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Location = new System.Drawing.Point(399, 215);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(56, 13);
            this.labelWin.TabIndex = 13;
            this.labelWin.Text = "Выиграш:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 339);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.pictureBoxGreen);
            this.Controls.Add(this.pictureBoxBlack);
            this.Controls.Add(this.pictureBoxRed);
            this.Controls.Add(this.radioButtonGreen);
            this.Controls.Add(this.radioButtonBlack);
            this.Controls.Add(this.radioButtonRed);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelCurrentAccount);
            this.Controls.Add(this.buttonGO);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ruletka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.Label labelCurrentAccount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pictureBoxRed;
        private System.Windows.Forms.PictureBox pictureBoxBlack;
        private System.Windows.Forms.PictureBox pictureBoxGreen;
        private System.Windows.Forms.PictureBox pictureBoxResult;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelWin;
    }
}

