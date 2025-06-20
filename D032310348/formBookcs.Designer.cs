namespace D032310348
{
    partial class formBookcs
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
            System.Windows.Forms.Label iSBN_13Label;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label publishDateLabel;
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.iSBN13DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admiralBookstore = new D032310348.AdmiralBookstore();
            this.bookTableAdapter = new D032310348.AdmiralBookstoreTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new D032310348.AdmiralBookstoreTableAdapters.TableAdapterManager();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.dateTimePickerPublish = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStockB = new System.Windows.Forms.Button();
            this.btnAuthorB = new System.Windows.Forms.Button();
            iSBN_13Label = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            publishDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBN_13Label
            // 
            iSBN_13Label.AutoSize = true;
            iSBN_13Label.Location = new System.Drawing.Point(196, 253);
            iSBN_13Label.Name = "iSBN_13Label";
            iSBN_13Label.Size = new System.Drawing.Size(59, 16);
            iSBN_13Label.TabIndex = 1;
            iSBN_13Label.Text = "ISBN-13:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(196, 281);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(196, 309);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(66, 16);
            publisherLabel.TabIndex = 5;
            publisherLabel.Text = "Publisher:";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new System.Drawing.Point(196, 338);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new System.Drawing.Size(86, 16);
            publishDateLabel.TabIndex = 7;
            publishDateLabel.Text = "Publish Date:";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoGenerateColumns = false;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBN13DataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn});
            this.dataGridViewBook.DataSource = this.bookBindingSource;
            this.dataGridViewBook.Location = new System.Drawing.Point(77, 42);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 51;
            this.dataGridViewBook.RowTemplate.Height = 24;
            this.dataGridViewBook.Size = new System.Drawing.Size(681, 165);
            this.dataGridViewBook.TabIndex = 0;
            // 
            // iSBN13DataGridViewTextBoxColumn
            // 
            this.iSBN13DataGridViewTextBoxColumn.DataPropertyName = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.HeaderText = "ISBN-13";
            this.iSBN13DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBN13DataGridViewTextBoxColumn.Name = "iSBN13DataGridViewTextBoxColumn";
            this.iSBN13DataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "PublishDate";
            this.publishDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.admiralBookstore;
            // 
            // admiralBookstore
            // 
            this.admiralBookstore.DataSetName = "AdmiralBookstore";
            this.admiralBookstore.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = D032310348.AdmiralBookstoreTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN-13", true));
            this.textBoxISBN.Location = new System.Drawing.Point(300, 250);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(321, 22);
            this.textBoxISBN.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.textBoxTitle.Location = new System.Drawing.Point(300, 278);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(321, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Publisher", true));
            this.textBoxPublisher.Location = new System.Drawing.Point(300, 309);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(321, 22);
            this.textBoxPublisher.TabIndex = 6;
            // 
            // dateTimePickerPublish
            // 
            this.dateTimePickerPublish.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "PublishDate", true));
            this.dateTimePickerPublish.Location = new System.Drawing.Point(300, 333);
            this.dateTimePickerPublish.Name = "dateTimePickerPublish";
            this.dateTimePickerPublish.Size = new System.Drawing.Size(321, 22);
            this.dateTimePickerPublish.TabIndex = 8;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(338, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 59);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStockB
            // 
            this.btnStockB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStockB.Location = new System.Drawing.Point(687, 468);
            this.btnStockB.Name = "btnStockB";
            this.btnStockB.Size = new System.Drawing.Size(135, 30);
            this.btnStockB.TabIndex = 11;
            this.btnStockB.Text = "Form Stock";
            this.btnStockB.UseVisualStyleBackColor = true;
            this.btnStockB.Click += new System.EventHandler(this.btnStockB_Click);
            // 
            // btnAuthorB
            // 
            this.btnAuthorB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAuthorB.Location = new System.Drawing.Point(687, 432);
            this.btnAuthorB.Name = "btnAuthorB";
            this.btnAuthorB.Size = new System.Drawing.Size(135, 30);
            this.btnAuthorB.TabIndex = 10;
            this.btnAuthorB.Text = "Form Author";
            this.btnAuthorB.UseVisualStyleBackColor = true;
            this.btnAuthorB.Click += new System.EventHandler(this.btnAuthorB_Click);
            // 
            // formBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 530);
            this.Controls.Add(this.btnStockB);
            this.Controls.Add(this.btnAuthorB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(iSBN_13Label);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(publisherLabel);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(publishDateLabel);
            this.Controls.Add(this.dateTimePickerPublish);
            this.Controls.Add(this.dataGridViewBook);
            this.Name = "formBook";
            this.Text = "Book Form";
            this.Load += new System.EventHandler(this.formBookcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admiralBookstore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBook;
        private AdmiralBookstore admiralBookstore;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private AdmiralBookstoreTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBN13DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private AdmiralBookstoreTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.DateTimePicker dateTimePickerPublish;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStockB;
        private System.Windows.Forms.Button btnAuthorB;
    }
}