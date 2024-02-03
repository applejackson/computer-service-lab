
namespace сервис
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbComputerServiceDataSet = new сервис.dbComputerServiceDataSet();
            this.запчастиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запчастиTableAdapter = new сервис.dbComputerServiceDataSetTableAdapters.ЗапчастиTableAdapter();
            this.zapIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backUp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbComputerServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("TT Travels Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zapIdDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.запчастиBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbComputerServiceDataSet
            // 
            this.dbComputerServiceDataSet.DataSetName = "dbComputerServiceDataSet";
            this.dbComputerServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запчастиBindingSource
            // 
            this.запчастиBindingSource.DataMember = "Запчасти";
            this.запчастиBindingSource.DataSource = this.dbComputerServiceDataSet;
            // 
            // запчастиTableAdapter
            // 
            this.запчастиTableAdapter.ClearBeforeFill = true;
            // 
            // zapIdDataGridViewTextBoxColumn
            // 
            this.zapIdDataGridViewTextBoxColumn.DataPropertyName = "zapId";
            this.zapIdDataGridViewTextBoxColumn.HeaderText = "zapId";
            this.zapIdDataGridViewTextBoxColumn.Name = "zapIdDataGridViewTextBoxColumn";
            this.zapIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // backUp
            // 
            this.backUp.AllowAnimations = true;
            this.backUp.AllowMouseEffects = true;
            this.backUp.AllowToggling = false;
            this.backUp.AnimationSpeed = 200;
            this.backUp.AutoGenerateColors = false;
            this.backUp.AutoRoundBorders = false;
            this.backUp.AutoSizeLeftIcon = true;
            this.backUp.AutoSizeRightIcon = true;
            this.backUp.BackColor = System.Drawing.Color.Transparent;
            this.backUp.BackColor1 = System.Drawing.Color.LightCyan;
            this.backUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backUp.BackgroundImage")));
            this.backUp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backUp.ButtonText = "Вернуться";
            this.backUp.ButtonTextMarginLeft = 0;
            this.backUp.ColorContrastOnClick = 45;
            this.backUp.ColorContrastOnHover = 45;
            this.backUp.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.backUp.CustomizableEdges = borderEdges1;
            this.backUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.backUp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.backUp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.backUp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.backUp.Font = new System.Drawing.Font("TT Travels DemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.backUp.ForeColor = System.Drawing.Color.Orchid;
            this.backUp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backUp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.backUp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.backUp.IconMarginLeft = 11;
            this.backUp.IconPadding = 10;
            this.backUp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backUp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.backUp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.backUp.IconSize = 25;
            this.backUp.IdleBorderColor = System.Drawing.Color.LightCyan;
            this.backUp.IdleBorderRadius = 1;
            this.backUp.IdleBorderThickness = 1;
            this.backUp.IdleFillColor = System.Drawing.Color.LightCyan;
            this.backUp.IdleIconLeftImage = null;
            this.backUp.IdleIconRightImage = null;
            this.backUp.IndicateFocus = false;
            this.backUp.Location = new System.Drawing.Point(527, 472);
            this.backUp.Name = "backUp";
            this.backUp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.backUp.OnDisabledState.BorderRadius = 1;
            this.backUp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backUp.OnDisabledState.BorderThickness = 1;
            this.backUp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.backUp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.backUp.OnDisabledState.IconLeftImage = null;
            this.backUp.OnDisabledState.IconRightImage = null;
            this.backUp.onHoverState.BorderColor = System.Drawing.Color.White;
            this.backUp.onHoverState.BorderRadius = 1;
            this.backUp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backUp.onHoverState.BorderThickness = 1;
            this.backUp.onHoverState.FillColor = System.Drawing.Color.White;
            this.backUp.onHoverState.ForeColor = System.Drawing.Color.HotPink;
            this.backUp.onHoverState.IconLeftImage = null;
            this.backUp.onHoverState.IconRightImage = null;
            this.backUp.OnIdleState.BorderColor = System.Drawing.Color.LightCyan;
            this.backUp.OnIdleState.BorderRadius = 1;
            this.backUp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backUp.OnIdleState.BorderThickness = 1;
            this.backUp.OnIdleState.FillColor = System.Drawing.Color.LightCyan;
            this.backUp.OnIdleState.ForeColor = System.Drawing.Color.Orchid;
            this.backUp.OnIdleState.IconLeftImage = null;
            this.backUp.OnIdleState.IconRightImage = null;
            this.backUp.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backUp.OnPressedState.BorderRadius = 1;
            this.backUp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.backUp.OnPressedState.BorderThickness = 1;
            this.backUp.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backUp.OnPressedState.ForeColor = System.Drawing.Color.HotPink;
            this.backUp.OnPressedState.IconLeftImage = null;
            this.backUp.OnPressedState.IconRightImage = null;
            this.backUp.Size = new System.Drawing.Size(193, 42);
            this.backUp.TabIndex = 6;
            this.backUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backUp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.backUp.TextMarginLeft = 0;
            this.backUp.TextPadding = new System.Windows.Forms.Padding(0);
            this.backUp.UseDefaultRadiusAndThickness = true;
            this.backUp.Click += new System.EventHandler(this.backUp_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(732, 526);
            this.Controls.Add(this.backUp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр данных запчастей";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbComputerServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запчастиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbComputerServiceDataSet dbComputerServiceDataSet;
        private System.Windows.Forms.BindingSource запчастиBindingSource;
        private dbComputerServiceDataSetTableAdapters.ЗапчастиTableAdapter запчастиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zapIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton backUp;
    }
}