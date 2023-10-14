
namespace ArosimClient
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_joints_data = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_conn_state = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.txb_conn_port = new System.Windows.Forms.TextBox();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ndd_step_size = new System.Windows.Forms.NumericUpDown();
            this.cbx_joint = new System.Windows.Forms.ComboBox();
            this.btn_catch_object = new System.Windows.Forms.Button();
            this.btn_deactivate = new System.Windows.Forms.Button();
            this.btn_activate = new System.Windows.Forms.Button();
            this.btn_x_up = new System.Windows.Forms.Button();
            this.btn_y_down = new System.Windows.Forms.Button();
            this.btn_x_down = new System.Windows.Forms.Button();
            this.btn_y_up = new System.Windows.Forms.Button();
            this.btn_central = new System.Windows.Forms.Button();
            this.btn_z_left = new System.Windows.Forms.Button();
            this.btn_z_right = new System.Windows.Forms.Button();
            this.tab_option = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_joints_data)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_step_size)).BeginInit();
            this.tab_option.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_joints_data
            // 
            this.dgv_joints_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_joints_data.Location = new System.Drawing.Point(12, 354);
            this.dgv_joints_data.Name = "dgv_joints_data";
            this.dgv_joints_data.Size = new System.Drawing.Size(793, 247);
            this.dgv_joints_data.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_connect);
            this.tabPage3.Controls.Add(this.lbl_conn_state);
            this.tabPage3.Controls.Add(this.lbl_state);
            this.tabPage3.Controls.Add(this.txb_conn_port);
            this.tabPage3.Controls.Add(this.txb_ip);
            this.tabPage3.Controls.Add(this.lbl_port);
            this.tabPage3.Controls.Add(this.lbl_ip);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(283, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configuracion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(172, 57);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(105, 23);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Conectar";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lbl_conn_state
            // 
            this.lbl_conn_state.AutoSize = true;
            this.lbl_conn_state.BackColor = System.Drawing.Color.Crimson;
            this.lbl_conn_state.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_conn_state.Location = new System.Drawing.Point(79, 63);
            this.lbl_conn_state.Name = "lbl_conn_state";
            this.lbl_conn_state.Size = new System.Drawing.Size(83, 13);
            this.lbl_conn_state.TabIndex = 5;
            this.lbl_conn_state.Text = "Desconectado..";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(7, 63);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(46, 13);
            this.lbl_state.TabIndex = 4;
            this.lbl_state.Text = "Estado: ";
            // 
            // txb_conn_port
            // 
            this.txb_conn_port.Location = new System.Drawing.Point(79, 31);
            this.txb_conn_port.Name = "txb_conn_port";
            this.txb_conn_port.Size = new System.Drawing.Size(198, 20);
            this.txb_conn_port.TabIndex = 3;
            this.txb_conn_port.Text = "585";
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(79, 4);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(198, 20);
            this.txb_ip.TabIndex = 1;
            this.txb_ip.Text = "127.0.0.1";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(7, 34);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(44, 13);
            this.lbl_port.TabIndex = 2;
            this.lbl_port.Text = "Puerto: ";
            // 
            // lbl_ip
            // 
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(7, 7);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(65, 13);
            this.lbl_ip.TabIndex = 0;
            this.lbl_ip.Text = "IP Servidor: ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ndd_step_size);
            this.tabPage1.Controls.Add(this.cbx_joint);
            this.tabPage1.Controls.Add(this.btn_catch_object);
            this.tabPage1.Controls.Add(this.btn_deactivate);
            this.tabPage1.Controls.Add(this.btn_activate);
            this.tabPage1.Controls.Add(this.btn_x_up);
            this.tabPage1.Controls.Add(this.btn_y_down);
            this.tabPage1.Controls.Add(this.btn_x_down);
            this.tabPage1.Controls.Add(this.btn_y_up);
            this.tabPage1.Controls.Add(this.btn_central);
            this.tabPage1.Controls.Add(this.btn_z_left);
            this.tabPage1.Controls.Add(this.btn_z_right);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Paso: ";
            // 
            // ndd_step_size
            // 
            this.ndd_step_size.Location = new System.Drawing.Point(56, 255);
            this.ndd_step_size.Name = "ndd_step_size";
            this.ndd_step_size.Size = new System.Drawing.Size(75, 20);
            this.ndd_step_size.TabIndex = 6;
            this.ndd_step_size.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbx_joint
            // 
            this.cbx_joint.FormattingEnabled = true;
            this.cbx_joint.Items.AddRange(new object[] {
            "P0",
            "B0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "G0"});
            this.cbx_joint.Location = new System.Drawing.Point(36, 6);
            this.cbx_joint.Name = "cbx_joint";
            this.cbx_joint.Size = new System.Drawing.Size(219, 21);
            this.cbx_joint.TabIndex = 3;
            this.cbx_joint.SelectedIndexChanged += new System.EventHandler(this.cbx_joint_SelectedIndexChanged);
            // 
            // btn_catch_object
            // 
            this.btn_catch_object.Location = new System.Drawing.Point(187, 191);
            this.btn_catch_object.Name = "btn_catch_object";
            this.btn_catch_object.Size = new System.Drawing.Size(68, 39);
            this.btn_catch_object.TabIndex = 5;
            this.btn_catch_object.Text = "Capturar";
            this.btn_catch_object.UseVisualStyleBackColor = true;
            this.btn_catch_object.Click += new System.EventHandler(this.btn_catch_object_Click);
            // 
            // btn_deactivate
            // 
            this.btn_deactivate.Location = new System.Drawing.Point(113, 191);
            this.btn_deactivate.Name = "btn_deactivate";
            this.btn_deactivate.Size = new System.Drawing.Size(68, 39);
            this.btn_deactivate.TabIndex = 5;
            this.btn_deactivate.Text = "Close";
            this.btn_deactivate.UseVisualStyleBackColor = true;
            this.btn_deactivate.Click += new System.EventHandler(this.btn_deactivate_Click);
            // 
            // btn_activate
            // 
            this.btn_activate.Location = new System.Drawing.Point(36, 191);
            this.btn_activate.Name = "btn_activate";
            this.btn_activate.Size = new System.Drawing.Size(71, 39);
            this.btn_activate.TabIndex = 5;
            this.btn_activate.Text = "Open";
            this.btn_activate.UseVisualStyleBackColor = true;
            this.btn_activate.Click += new System.EventHandler(this.btn_activate_Click);
            // 
            // btn_x_up
            // 
            this.btn_x_up.BackgroundImage = global::ArosimClient.Properties.Resources.up_x;
            this.btn_x_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_x_up.Location = new System.Drawing.Point(169, 42);
            this.btn_x_up.Name = "btn_x_up";
            this.btn_x_up.Size = new System.Drawing.Size(40, 39);
            this.btn_x_up.TabIndex = 5;
            this.btn_x_up.UseVisualStyleBackColor = true;
            this.btn_x_up.Click += new System.EventHandler(this.btn_x_up_Click);
            // 
            // btn_y_down
            // 
            this.btn_y_down.BackgroundImage = global::ArosimClient.Properties.Resources.down_y;
            this.btn_y_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_y_down.Location = new System.Drawing.Point(123, 132);
            this.btn_y_down.Name = "btn_y_down";
            this.btn_y_down.Size = new System.Drawing.Size(40, 39);
            this.btn_y_down.TabIndex = 4;
            this.btn_y_down.UseVisualStyleBackColor = true;
            this.btn_y_down.Click += new System.EventHandler(this.btn_y_down_Click);
            // 
            // btn_x_down
            // 
            this.btn_x_down.BackgroundImage = global::ArosimClient.Properties.Resources.donw_x;
            this.btn_x_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_x_down.Location = new System.Drawing.Point(75, 132);
            this.btn_x_down.Name = "btn_x_down";
            this.btn_x_down.Size = new System.Drawing.Size(41, 39);
            this.btn_x_down.TabIndex = 5;
            this.btn_x_down.UseVisualStyleBackColor = true;
            this.btn_x_down.Click += new System.EventHandler(this.btn_x_down_Click);
            // 
            // btn_y_up
            // 
            this.btn_y_up.BackgroundImage = global::ArosimClient.Properties.Resources.up_y;
            this.btn_y_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_y_up.Location = new System.Drawing.Point(122, 42);
            this.btn_y_up.Name = "btn_y_up";
            this.btn_y_up.Size = new System.Drawing.Size(41, 39);
            this.btn_y_up.TabIndex = 2;
            this.btn_y_up.UseVisualStyleBackColor = true;
            this.btn_y_up.Click += new System.EventHandler(this.btn_y_up_Click);
            // 
            // btn_central
            // 
            this.btn_central.BackgroundImage = global::ArosimClient.Properties.Resources.centre;
            this.btn_central.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_central.Location = new System.Drawing.Point(122, 87);
            this.btn_central.Name = "btn_central";
            this.btn_central.Size = new System.Drawing.Size(41, 39);
            this.btn_central.TabIndex = 2;
            this.btn_central.UseVisualStyleBackColor = true;
            this.btn_central.Click += new System.EventHandler(this.btn_central_Click);
            // 
            // btn_z_left
            // 
            this.btn_z_left.BackgroundImage = global::ArosimClient.Properties.Resources.left_z;
            this.btn_z_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_z_left.Location = new System.Drawing.Point(75, 87);
            this.btn_z_left.Name = "btn_z_left";
            this.btn_z_left.Size = new System.Drawing.Size(41, 39);
            this.btn_z_left.TabIndex = 2;
            this.btn_z_left.UseVisualStyleBackColor = true;
            this.btn_z_left.Click += new System.EventHandler(this.btn_z_left_Click);
            // 
            // btn_z_right
            // 
            this.btn_z_right.BackgroundImage = global::ArosimClient.Properties.Resources.right_z;
            this.btn_z_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_z_right.Location = new System.Drawing.Point(169, 87);
            this.btn_z_right.Name = "btn_z_right";
            this.btn_z_right.Size = new System.Drawing.Size(40, 39);
            this.btn_z_right.TabIndex = 2;
            this.btn_z_right.UseVisualStyleBackColor = true;
            this.btn_z_right.Click += new System.EventHandler(this.btn_z_right_Click);
            // 
            // tab_option
            // 
            this.tab_option.Controls.Add(this.tabPage1);
            this.tab_option.Controls.Add(this.tabPage3);
            this.tab_option.Location = new System.Drawing.Point(514, 12);
            this.tab_option.Name = "tab_option";
            this.tab_option.SelectedIndex = 0;
            this.tab_option.Size = new System.Drawing.Size(291, 336);
            this.tab_option.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 608);
            this.Controls.Add(this.dgv_joints_data);
            this.Controls.Add(this.tab_option);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Cliente";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_joints_data)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndd_step_size)).EndInit();
            this.tab_option.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_joints_data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_conn_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.TextBox txb_conn_port;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbx_joint;
        private System.Windows.Forms.Button btn_deactivate;
        private System.Windows.Forms.Button btn_activate;
        private System.Windows.Forms.Button btn_x_up;
        private System.Windows.Forms.Button btn_y_down;
        private System.Windows.Forms.Button btn_x_down;
        private System.Windows.Forms.Button btn_y_up;
        private System.Windows.Forms.Button btn_central;
        private System.Windows.Forms.Button btn_z_left;
        private System.Windows.Forms.Button btn_z_right;
        private System.Windows.Forms.TabControl tab_option;
        private System.Windows.Forms.Button btn_catch_object;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ndd_step_size;
    }
}

