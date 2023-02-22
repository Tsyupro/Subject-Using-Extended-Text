namespace Subject_Using_Extended_Text
{
    partial class Exercise2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonIcons = new System.Windows.Forms.RadioButton();
            this.radioButtonTiles = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 378);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(156, 23);
            this.textBox1.TabIndex = 2;
            // 
            // radioButtonIcons
            // 
            this.radioButtonIcons.AutoSize = true;
            this.radioButtonIcons.Location = new System.Drawing.Point(311, 408);
            this.radioButtonIcons.Name = "radioButtonIcons";
            this.radioButtonIcons.Size = new System.Drawing.Size(53, 19);
            this.radioButtonIcons.TabIndex = 3;
            this.radioButtonIcons.TabStop = true;
            this.radioButtonIcons.Text = "icons";
            this.radioButtonIcons.UseVisualStyleBackColor = true;
            this.radioButtonIcons.CheckedChanged += new System.EventHandler(this.radioButtonIcons_CheckedChanged);
            // 
            // radioButtonTiles
            // 
            this.radioButtonTiles.AutoSize = true;
            this.radioButtonTiles.Location = new System.Drawing.Point(435, 408);
            this.radioButtonTiles.Name = "radioButtonTiles";
            this.radioButtonTiles.Size = new System.Drawing.Size(46, 19);
            this.radioButtonTiles.TabIndex = 4;
            this.radioButtonTiles.TabStop = true;
            this.radioButtonTiles.Text = "tiles";
            this.radioButtonTiles.UseVisualStyleBackColor = true;
            this.radioButtonTiles.CheckedChanged += new System.EventHandler(this.radioButtonTiles_CheckedChanged);
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(547, 406);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(40, 19);
            this.radioButtonList.TabIndex = 5;
            this.radioButtonList.TabStop = true;
            this.radioButtonList.Text = "list";
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.CheckedChanged += new System.EventHandler(this.radioButtonList_CheckedChanged);
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonList);
            this.Controls.Add(this.radioButtonTiles);
            this.Controls.Add(this.radioButtonIcons);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Exercise2";
            this.Text = "Exercise2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private Button button1;
        private TextBox textBox1;
        private RadioButton radioButtonIcons;
        private RadioButton radioButtonTiles;
        private RadioButton radioButtonList;
    }
}