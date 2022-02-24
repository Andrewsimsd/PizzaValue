
namespace PizzaValue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbPizza1Price = new System.Windows.Forms.TextBox();
            this.tbPizza2Price = new System.Windows.Forms.TextBox();
            this.formsPlotPizza1Crust = new ScottPlot.FormsPlot();
            this.tbPizza1Size = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPizza1PricePerSqIn = new System.Windows.Forms.Label();
            this.tbPizza2Size = new System.Windows.Forms.TextBox();
            this.labelPizza2PricePerSqIn = new System.Windows.Forms.Label();
            this.labelPizza1AdjValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPizza2AdjValue = new System.Windows.Forms.Label();
            this.labelPizza1CrustDescription = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPizza2CrustDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarPizza1CrustValue = new System.Windows.Forms.TrackBar();
            this.trackBarPizza2CrustValue = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPizza1CrustValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPizza2CrustValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPizza1Price
            // 
            this.tbPizza1Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPizza1Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPizza1Price.ForeColor = System.Drawing.Color.White;
            this.tbPizza1Price.Location = new System.Drawing.Point(211, 43);
            this.tbPizza1Price.Name = "tbPizza1Price";
            this.tbPizza1Price.Size = new System.Drawing.Size(202, 33);
            this.tbPizza1Price.TabIndex = 2;
            this.tbPizza1Price.TextChanged += new System.EventHandler(this.tbPizza1Price_TextChanged);
            // 
            // tbPizza2Price
            // 
            this.tbPizza2Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPizza2Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPizza2Price.ForeColor = System.Drawing.Color.White;
            this.tbPizza2Price.Location = new System.Drawing.Point(419, 43);
            this.tbPizza2Price.Name = "tbPizza2Price";
            this.tbPizza2Price.Size = new System.Drawing.Size(204, 33);
            this.tbPizza2Price.TabIndex = 4;
            this.tbPizza2Price.TextChanged += new System.EventHandler(this.tbPizza2Price_TextChanged);
            // 
            // formsPlotPizza1Crust
            // 
            this.formsPlotPizza1Crust.Location = new System.Drawing.Point(394, 156);
            this.formsPlotPizza1Crust.Margin = new System.Windows.Forms.Padding(6);
            this.formsPlotPizza1Crust.Name = "formsPlotPizza1Crust";
            this.formsPlotPizza1Crust.Size = new System.Drawing.Size(166, 167);
            this.formsPlotPizza1Crust.TabIndex = 7;
            // 
            // tbPizza1Size
            // 
            this.tbPizza1Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPizza1Size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPizza1Size.ForeColor = System.Drawing.Color.White;
            this.tbPizza1Size.Location = new System.Drawing.Point(211, 83);
            this.tbPizza1Size.Name = "tbPizza1Size";
            this.tbPizza1Size.Size = new System.Drawing.Size(202, 33);
            this.tbPizza1Size.TabIndex = 10;
            this.tbPizza1Size.TextChanged += new System.EventHandler(this.tbPizza1Size_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pizza Size (in.)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price / Sq. in.";
            // 
            // labelPizza1PricePerSqIn
            // 
            this.labelPizza1PricePerSqIn.AutoSize = true;
            this.labelPizza1PricePerSqIn.ForeColor = System.Drawing.Color.White;
            this.labelPizza1PricePerSqIn.Location = new System.Drawing.Point(214, 120);
            this.labelPizza1PricePerSqIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPizza1PricePerSqIn.Name = "labelPizza1PricePerSqIn";
            this.labelPizza1PricePerSqIn.Size = new System.Drawing.Size(45, 25);
            this.labelPizza1PricePerSqIn.TabIndex = 12;
            this.labelPizza1PricePerSqIn.Text = "N/A";
            // 
            // tbPizza2Size
            // 
            this.tbPizza2Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPizza2Size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPizza2Size.ForeColor = System.Drawing.Color.White;
            this.tbPizza2Size.Location = new System.Drawing.Point(419, 83);
            this.tbPizza2Size.Name = "tbPizza2Size";
            this.tbPizza2Size.Size = new System.Drawing.Size(204, 33);
            this.tbPizza2Size.TabIndex = 15;
            this.tbPizza2Size.TextChanged += new System.EventHandler(this.tbPizza2Size_TextChanged);
            // 
            // labelPizza2PricePerSqIn
            // 
            this.labelPizza2PricePerSqIn.AutoSize = true;
            this.labelPizza2PricePerSqIn.ForeColor = System.Drawing.Color.White;
            this.labelPizza2PricePerSqIn.Location = new System.Drawing.Point(422, 120);
            this.labelPizza2PricePerSqIn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPizza2PricePerSqIn.Name = "labelPizza2PricePerSqIn";
            this.labelPizza2PricePerSqIn.Size = new System.Drawing.Size(45, 25);
            this.labelPizza2PricePerSqIn.TabIndex = 17;
            this.labelPizza2PricePerSqIn.Text = "N/A";
            // 
            // labelPizza1AdjValue
            // 
            this.labelPizza1AdjValue.AutoSize = true;
            this.labelPizza1AdjValue.ForeColor = System.Drawing.Color.White;
            this.labelPizza1AdjValue.Location = new System.Drawing.Point(214, 240);
            this.labelPizza1AdjValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPizza1AdjValue.Name = "labelPizza1AdjValue";
            this.labelPizza1AdjValue.Size = new System.Drawing.Size(45, 25);
            this.labelPizza1AdjValue.TabIndex = 19;
            this.labelPizza1AdjValue.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Crust Adjusted Value";
            // 
            // labelPizza2AdjValue
            // 
            this.labelPizza2AdjValue.AutoSize = true;
            this.labelPizza2AdjValue.ForeColor = System.Drawing.Color.White;
            this.labelPizza2AdjValue.Location = new System.Drawing.Point(422, 240);
            this.labelPizza2AdjValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPizza2AdjValue.Name = "labelPizza2AdjValue";
            this.labelPizza2AdjValue.Size = new System.Drawing.Size(45, 25);
            this.labelPizza2AdjValue.TabIndex = 21;
            this.labelPizza2AdjValue.Text = "N/A";
            // 
            // labelPizza1CrustDescription
            // 
            this.labelPizza1CrustDescription.AutoSize = true;
            this.labelPizza1CrustDescription.ForeColor = System.Drawing.Color.White;
            this.labelPizza1CrustDescription.Location = new System.Drawing.Point(214, 200);
            this.labelPizza1CrustDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPizza1CrustDescription.Name = "labelPizza1CrustDescription";
            this.labelPizza1CrustDescription.Size = new System.Drawing.Size(157, 25);
            this.labelPizza1CrustDescription.TabIndex = 22;
            this.labelPizza1CrustDescription.Text = "Crust Description";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPizza2CrustDescription, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbPizza1Price, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPizza1CrustDescription, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.trackBarPizza2CrustValue, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPizza2PricePerSqIn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPizza1Size, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbPizza2Size, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPizza1PricePerSqIn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.trackBarPizza1CrustValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbPizza2Price, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelPizza1AdjValue, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelPizza2AdjValue, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 294);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(276, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Pizza 1";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(485, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 25;
            this.label12.Text = "Pizza 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Pizza Price";
            // 
            // labelPizza2CrustDescription
            // 
            this.labelPizza2CrustDescription.AutoSize = true;
            this.labelPizza2CrustDescription.ForeColor = System.Drawing.Color.White;
            this.labelPizza2CrustDescription.Location = new System.Drawing.Point(422, 200);
            this.labelPizza2CrustDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPizza2CrustDescription.Name = "labelPizza2CrustDescription";
            this.labelPizza2CrustDescription.Size = new System.Drawing.Size(157, 25);
            this.labelPizza2CrustDescription.TabIndex = 23;
            this.labelPizza2CrustDescription.Text = "Crust Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crust Value";
            // 
            // trackBarPizza1CrustValue
            // 
            this.trackBarPizza1CrustValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarPizza1CrustValue.Location = new System.Drawing.Point(211, 163);
            this.trackBarPizza1CrustValue.Name = "trackBarPizza1CrustValue";
            this.trackBarPizza1CrustValue.Size = new System.Drawing.Size(202, 34);
            this.trackBarPizza1CrustValue.TabIndex = 8;
            this.trackBarPizza1CrustValue.Scroll += new System.EventHandler(this.trackBarPizza1CrustValue_Scroll);
            // 
            // trackBarPizza2CrustValue
            // 
            this.trackBarPizza2CrustValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarPizza2CrustValue.Location = new System.Drawing.Point(419, 163);
            this.trackBarPizza2CrustValue.Name = "trackBarPizza2CrustValue";
            this.trackBarPizza2CrustValue.Size = new System.Drawing.Size(204, 34);
            this.trackBarPizza2CrustValue.TabIndex = 13;
            this.trackBarPizza2CrustValue.Scroll += new System.EventHandler(this.trackBarPizza2CrustValue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(626, 294);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.formsPlotPizza1Crust);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Pizza Value";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPizza1CrustValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPizza2CrustValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbPizza1Price;
        private System.Windows.Forms.TextBox tbPizza2Price;
        private ScottPlot.FormsPlot formsPlotPizza1Crust;
        private System.Windows.Forms.TextBox tbPizza1Size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPizza1PricePerSqIn;
        private System.Windows.Forms.TextBox tbPizza2Size;
        private System.Windows.Forms.Label labelPizza2PricePerSqIn;
        private System.Windows.Forms.Label labelPizza1AdjValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPizza2AdjValue;
        private System.Windows.Forms.Label labelPizza1CrustDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPizza2CrustDescription;
        private System.Windows.Forms.TrackBar trackBarPizza2CrustValue;
        private System.Windows.Forms.TrackBar trackBarPizza1CrustValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

