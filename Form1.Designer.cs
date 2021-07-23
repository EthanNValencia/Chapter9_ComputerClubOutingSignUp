
namespace Chapter9_ComputerClubOutingSignUp
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
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBoxEvents = new System.Windows.Forms.ListBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAddItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(13, 333);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(260, 34);
            this.txtBoxResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Event(s)";
            // 
            // lstBoxEvents
            // 
            this.lstBoxEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstBoxEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lstBoxEvents.FormattingEnabled = true;
            this.lstBoxEvents.ItemHeight = 28;
            this.lstBoxEvents.Items.AddRange(new object[] {
            "Amusement Park",
            "Boat Tour",
            "Dance",
            "Dinner",
            "Hike",
            "Movie",
            "Sporting Event"});
            this.lstBoxEvents.Location = new System.Drawing.Point(13, 44);
            this.lstBoxEvents.Name = "lstBoxEvents";
            this.lstBoxEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxEvents.Size = new System.Drawing.Size(260, 116);
            this.lstBoxEvents.Sorted = true;
            this.lstBoxEvents.TabIndex = 3;
            this.lstBoxEvents.SelectedIndexChanged += new System.EventHandler(this.lstBoxEvents_SelectedIndexChanged);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(76, 244);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(112, 43);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Item:";
            // 
            // txtBoxAddItem
            // 
            this.txtBoxAddItem.Location = new System.Drawing.Point(115, 173);
            this.txtBoxAddItem.Name = "txtBoxAddItem";
            this.txtBoxAddItem.Size = new System.Drawing.Size(158, 34);
            this.txtBoxAddItem.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(286, 380);
            this.Controls.Add(this.txtBoxAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lstBoxEvents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxResult);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Computer Club Outing SIgn Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBoxEvents;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAddItem;
    }
}

