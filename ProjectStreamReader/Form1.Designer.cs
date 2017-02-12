namespace ProjectStreamReader
{
    partial class frmStreamReader
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnWriteNumbers = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReverseNumber = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 227);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(394, 144);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // btnWriteNumbers
            // 
            this.btnWriteNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteNumbers.Location = new System.Drawing.Point(236, 131);
            this.btnWriteNumbers.Name = "btnWriteNumbers";
            this.btnWriteNumbers.Size = new System.Drawing.Size(170, 40);
            this.btnWriteNumbers.TabIndex = 1;
            this.btnWriteNumbers.Text = "Write Number";
            this.btnWriteNumbers.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(236, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search File";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteFile.Location = new System.Drawing.Point(12, 131);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(170, 40);
            this.btnWriteFile.TabIndex = 3;
            this.btnWriteFile.Text = "Write File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            // 
            // btnReverseNumber
            // 
            this.btnReverseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverseNumber.Location = new System.Drawing.Point(12, 74);
            this.btnReverseNumber.Name = "btnReverseNumber";
            this.btnReverseNumber.Size = new System.Drawing.Size(170, 40);
            this.btnReverseNumber.TabIndex = 4;
            this.btnReverseNumber.Text = "Reverse Number";
            this.btnReverseNumber.UseVisualStyleBackColor = true;
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(12, 14);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(170, 40);
            this.btnReadFile.TabIndex = 5;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(107, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 183);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(236, 34);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(169, 20);
            this.txtInput.TabIndex = 8;
            // 
            // frmStreamReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 382);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnReverseNumber);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnWriteNumbers);
            this.Controls.Add(this.rtbDisplay);
            this.Name = "frmStreamReader";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnWriteNumbers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReverseNumber;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtInput;
    }
}

