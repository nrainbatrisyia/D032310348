namespace D032310348
{
    partial class formStock
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
            System.Windows.Forms.Label stockIDLabel;
            System.Windows.Forms.Label authorIDLabel;
            System.Windows.Forms.Label iSBN_13Label;
            System.Windows.Forms.Label quantityInStockLabel;
            System.Windows.Forms.Label dateRecordedLabel;
            this.admiralBookstore = new D032310348.AdmiralBookstore();
            this.stockTableAdapter = new D032310348.AdmiralBookstoreTableAdapters.StockTableAdapter();
            this.tableAdapterManager = new D032310348.AdmiralBookstoreTableAdapters.TableAdapterManager();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.dateRecordedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBookS = new System.Windows.Forms.Button();
            this.btnAuthorS = new System.Windows.Forms.Button();
            stockIDLabel = new System.Windows.Forms.Label();
            authorIDLabel = new System.Windows.Forms.Label();
            iSBN_13Label = new System.Windows.Forms.Label();
            quantityInStockLabel = new System.Windows.Forms.Label();
            dateRecordedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = this.stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = D032310348.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.admiralBookstore;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoGenerateColumns = false;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridViewStock.DataSource = this.stockBindingSource;
            this.dataGridViewStock.Location = new System.Drawing.Point(78, 43);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.RowHeadersWidth = 51;
            this.dataGridViewStock.RowTemplate.Height = 24;
            this.dataGridViewStock.Size = new System.Drawing.Size(695, 153);
            this.dataGridViewStock.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StockID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StockID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AuthorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "AuthorID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ISBN-13";
            this.dataGridViewTextBoxColumn3.HeaderText = "ISBN-13";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantityInStock";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantityInStock";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateRecorded";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateRecorded";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // stockIDLabel
            // 
            stockIDLabel.AutoSize = true;
            stockIDLabel.Location = new System.Drawing.Point(186, 234);
            stockIDLabel.Name = "stockIDLabel";
            stockIDLabel.Size = new System.Drawing.Size(60, 16);
            stockIDLabel.TabIndex = 1;
            stockIDLabel.Text = "Stock ID:";
            // 
            // textBoxStock
            // 
            this.textBoxStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "StockID", true));
            this.textBoxStock.Location = new System.Drawing.Point(316, 234);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(297, 22);
            this.textBoxStock.TabIndex = 2;
            // 
            // authorIDLabel
            // 
            authorIDLabel.AutoSize = true;
            authorIDLabel.Location = new System.Drawing.Point(186, 262);
            authorIDLabel.Name = "authorIDLabel";
            authorIDLabel.Size = new System.Drawing.Size(64, 16);
            authorIDLabel.TabIndex = 3;
            authorIDLabel.Text = "Author ID:";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "AuthorID", true));
            this.textBoxAuthor.Location = new System.Drawing.Point(316, 259);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(297, 22);
            this.textBoxAuthor.TabIndex = 4;
            // 
            // iSBN_13Label
            // 
            iSBN_13Label.AutoSize = true;
            iSBN_13Label.Location = new System.Drawing.Point(186, 290);
            iSBN_13Label.Name = "iSBN_13Label";
            iSBN_13Label.Size = new System.Drawing.Size(59, 16);
            iSBN_13Label.TabIndex = 5;
            iSBN_13Label.Text = "ISBN-13:";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "ISBN-13", true));
            this.textBoxISBN.Location = new System.Drawing.Point(316, 287);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(297, 22);
            this.textBoxISBN.TabIndex = 6;
            // 
            // quantityInStockLabel
            // 
            quantityInStockLabel.AutoSize = true;
            quantityInStockLabel.Location = new System.Drawing.Point(186, 318);
            quantityInStockLabel.Name = "quantityInStockLabel";
            quantityInStockLabel.Size = new System.Drawing.Size(108, 16);
            quantityInStockLabel.TabIndex = 7;
            quantityInStockLabel.Text = "Quantity In Stock:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stockBindingSource, "QuantityInStock", true));
            this.textBoxQuantity.Location = new System.Drawing.Point(316, 315);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(297, 22);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // dateRecordedLabel
            // 
            dateRecordedLabel.AutoSize = true;
            dateRecordedLabel.Location = new System.Drawing.Point(186, 347);
            dateRecordedLabel.Name = "dateRecordedLabel";
            dateRecordedLabel.Size = new System.Drawing.Size(103, 16);
            dateRecordedLabel.TabIndex = 9;
            dateRecordedLabel.Text = "Date Recorded:";
            // 
            // dateRecordedDateTimePicker
            // 
            this.dateRecordedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.stockBindingSource, "DateRecorded", true));
            this.dateRecordedDateTimePicker.Location = new System.Drawing.Point(316, 341);
            this.dateRecordedDateTimePicker.Name = "dateRecordedDateTimePicker";
            this.dateRecordedDateTimePicker.Size = new System.Drawing.Size(297, 22);
            this.dateRecordedDateTimePicker.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(353, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(152, 59);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBookS
            // 
            this.btnBookS.AutoEllipsis = true;
            this.btnBookS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookS.Location = new System.Drawing.Point(693, 480);
            this.btnBookS.Name = "btnBookS";
            this.btnBookS.Size = new System.Drawing.Size(135, 30);
            this.btnBookS.TabIndex = 13;
            this.btnBookS.Text = "Form Book";
            this.btnBookS.UseVisualStyleBackColor = true;
            this.btnBookS.Click += new System.EventHandler(this.btnBookS_Click);
            // 
            // btnAuthorS
            // 
            this.btnAuthorS.AutoEllipsis = true;
            this.btnAuthorS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthorS.Location = new System.Drawing.Point(693, 444);
            this.btnAuthorS.Name = "btnAuthorS";
            this.btnAuthorS.Size = new System.Drawing.Size(135, 30);
            this.btnAuthorS.TabIndex = 12;
            this.btnAuthorS.Text = "Form Author";
            this.btnAuthorS.UseVisualStyleBackColor = true;
            this.btnAuthorS.Click += new System.EventHandler(this.btnAuthorS_Click);
            // 
            // formStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 530);
            this.Controls.Add(this.btnBookS);
            this.Controls.Add(this.btnAuthorS);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(stockIDLabel);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(authorIDLabel);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(iSBN_13Label);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(quantityInStockLabel);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(dateRecordedLabel);
            this.Controls.Add(this.dateRecordedDateTimePicker);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "formStock";
            this.Text = "Stock Form";
            this.Load += new System.EventHandler(this.formStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AdmiralBookstore admiralBookstore;
        private AdmiralBookstoreTableAdapters.StockTableAdapter stockTableAdapter;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.DateTimePicker dateRecordedDateTimePicker;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBookS;
        private System.Windows.Forms.Button btnAuthorS;
    }
}