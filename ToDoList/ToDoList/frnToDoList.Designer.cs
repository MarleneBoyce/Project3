using System;

namespace ToDoList
{
    partial class ToDoList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnClearLists = new System.Windows.Forms.Button();
            this.btnSaveLists = new System.Windows.Forms.Button();
            this.btnLoadLists = new System.Windows.Forms.Button();
            this.cblbLToDoList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDone = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(132, 69);
            this.txtItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(276, 29);
            this.txtItem.TabIndex = 0;
 
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(194, 111);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(125, 32);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnClearLists
            // 
            this.btnClearLists.Location = new System.Drawing.Point(208, 452);
            this.btnClearLists.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClearLists.Name = "btnClearLists";
            this.btnClearLists.Size = new System.Drawing.Size(149, 32);
            this.btnClearLists.TabIndex = 2;
            this.btnClearLists.Text = "Clear Lists";
            this.btnClearLists.UseVisualStyleBackColor = true;
            this.btnClearLists.Click += new System.EventHandler(this.btnClearLists_Click);
            // 
            // btnSaveLists
            // 
            this.btnSaveLists.Location = new System.Drawing.Point(403, 452);
            this.btnSaveLists.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveLists.Name = "btnSaveLists";
            this.btnSaveLists.Size = new System.Drawing.Size(149, 32);
            this.btnSaveLists.TabIndex = 3;
            this.btnSaveLists.Text = "Save Lists";
            this.btnSaveLists.UseVisualStyleBackColor = true;
            this.btnSaveLists.Click += new System.EventHandler(this.btnSaveLists_Click);
            // 
            // btnLoadLists
            // 
            this.btnLoadLists.Location = new System.Drawing.Point(581, 452);
            this.btnLoadLists.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLoadLists.Name = "btnLoadLists";
            this.btnLoadLists.Size = new System.Drawing.Size(149, 32);
            this.btnLoadLists.TabIndex = 4;
            this.btnLoadLists.Text = "Load Lists";
            this.btnLoadLists.UseVisualStyleBackColor = true;
            this.btnLoadLists.Click += new System.EventHandler(this.btnLoadLists_Click);
            // 
            // cblbLToDoList
            // 
            this.cblbLToDoList.FormattingEnabled = true;
            this.cblbLToDoList.Location = new System.Drawing.Point(79, 203);
            this.cblbLToDoList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cblbLToDoList.Name = "cblbLToDoList";
            this.cblbLToDoList.Size = new System.Drawing.Size(369, 196);
            this.cblbLToDoList.TabIndex = 3;
            this.cblbLToDoList.SelectedValueChanged += new System.EventHandler(this.cblbLToDoList_SelectedValueChanged);
            this.cblbLToDoList.DoubleClick += new System.EventHandler(this.cblbLToDoList_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "To-Do Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Completed Items";
            // 
            // lbDone
            // 
            this.lbDone.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDone.FormattingEnabled = true;
            this.lbDone.ItemHeight = 22;
            this.lbDone.Location = new System.Drawing.Point(488, 208);
            this.lbDone.Name = "lbDone";
            this.lbDone.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDone.Size = new System.Drawing.Size(369, 202);
            this.lbDone.TabIndex = 6;
            // 
            // ToDoList
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 525);
            this.Controls.Add(this.lbDone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLoadLists);
            this.Controls.Add(this.btnSaveLists);
            this.Controls.Add(this.btnClearLists);
            this.Controls.Add(this.cblbLToDoList);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ToDoList";
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnClearLists;
        private System.Windows.Forms.Button btnSaveLists;
        private System.Windows.Forms.Button btnLoadLists;
        private System.Windows.Forms.CheckedListBox cblbLToDoList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbDone;
    }
}

