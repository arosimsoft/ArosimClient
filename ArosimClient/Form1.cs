using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArosimClient.Classes;


namespace ArosimClient
{
    
    public partial class Form1 : Form
    {

        private Client client;
        Thread connectionThread;

        public static bool isRunnig = false;
        private bool clientIsConnected = false;

        List<Joint> tmp_jointList;

        public Form1()
        {
            InitializeComponent();

            isRunnig = true;
            connectionThread = new Thread(new ThreadStart(ConnectionThread));
            connectionThread.Start();
        }

        public void FillDataTable()
        {
            if(isRunnig)
            {
                // Check if jointList is empty

                DataTable dataTable = new DataTable();

                tmp_jointList = ClientManager.jointsList.ToList();

                dataTable.Columns.Add("Joint", typeof(string));
                dataTable.Columns.Add("x", typeof(float));
                dataTable.Columns.Add("y", typeof(float));
                dataTable.Columns.Add("z", typeof(float));
                dataTable.Columns.Add("angle_x", typeof(float));
                dataTable.Columns.Add("angle_y", typeof(float));
                dataTable.Columns.Add("angle_z", typeof(float));

                foreach(Joint joint in tmp_jointList)
                {
                    dataTable.Rows.Add(
                        joint.name,
                        joint.x,
                        joint.y,
                        joint.z,
                        joint.angle_x,
                        joint.angle_y,
                        joint.angle_z
                        );
                }

                dgv_joints_data.DataSource = dataTable;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_joint.SelectedIndex = 0;
            timer1.Interval = Constants.MS_PER_TICK;
        }

        private static void ConnectionThread()
        {
            Console.WriteLine($"Connection thread started. Runnig at {Constants.TICKS_PER_SEC} ticks per second.");
            DateTime nextLoop = DateTime.Now;

            while (isRunnig)
            {
                while (nextLoop < DateTime.Now)
                {
                    SimulationLogic.Update();

                    nextLoop = nextLoop.AddMilliseconds(Constants.MS_PER_TICK);

                    if (nextLoop > DateTime.Now)
                    {
                        Thread.Sleep(nextLoop - DateTime.Now);
                    }
                }
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (!clientIsConnected)
            {
                client = Client.GetInstance(2, txb_ip.Text, int.Parse(txb_conn_port.Text));
                client.ConnectToServer();
                timer1.Start();

                clientIsConnected = true;
                lbl_conn_state.Text = "Conectado al servidor.";
                lbl_conn_state.BackColor = Color.Green;
                btn_connect.Text = "Desconectar";
            }
            else
            {
                client.Disconnect();
                timer1.Stop();

                clientIsConnected = false;
                lbl_conn_state.Text = "Desconectado del servidor.";
                lbl_conn_state.BackColor = Color.Red;
                btn_connect.Text = "Conectar";
            }
           
        }

        private void btn_z_right_Click(object sender, EventArgs e)
        {
         

            switch (cbx_joint.Text)
            {
                case "B0":
                    break;
                case "P0":
                    ClientSend.ClientControlCommand($"move_base {ndd_step_size.Value:F6}");
                    break;
                case "F1":
                    break;
                case "F2":
                    break;
                case "F3":
                    ClientSend.ClientControlCommand($"rotate_f3 {ndd_step_size.Value:F6}");
                    break;
                case "F4":
                    ClientSend.ClientControlCommand($"rotate_f4 {ndd_step_size.Value:F6}");
                    break;
                case "F5":
                    break;
                case "G0":
                    break;
                default:
                    break;
            }
        }

        private void btn_central_Click(object sender, EventArgs e)
        {
            ClientSend.ClientControlCommand("home_position");
        }

        private void cbx_joint_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbx_joint.Text)
            {
                case "B0":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = false;
                    btn_x_down.Enabled = false;
                    btn_y_up.Enabled = true;
                    btn_y_down.Enabled = true;
                    btn_z_left.Enabled = false;
                    btn_z_right.Enabled = false;
                    btn_activate.Enabled = false;
                    btn_deactivate.Enabled = false;
                    btn_catch_object.Enabled = false;
                    break;
                case "P0":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = false;
                    btn_x_down.Enabled = false;
                    btn_y_up.Enabled = false;
                    btn_y_down.Enabled = false;
                    btn_z_left.Enabled = true;
                    btn_z_right.Enabled = true;
                    btn_activate.Enabled = false;
                    btn_deactivate.Enabled = false;
                    btn_catch_object.Enabled = false;
                    break;
                case "F1":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = true;
                    btn_x_down.Enabled = true;
                    btn_y_up.Enabled = false;
                    btn_y_down.Enabled = false;
                    btn_z_left.Enabled = false;
                    btn_z_right.Enabled = false;
                    btn_activate.Enabled = false;
                    btn_deactivate.Enabled = false;
                    btn_catch_object.Enabled = false;
                    break;
                case "F2":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = true;
                    btn_x_down.Enabled = true;
                    btn_y_up.Enabled = false;
                    btn_y_down.Enabled = false;
                    btn_z_left.Enabled = false;
                    btn_z_right.Enabled = false;
                    btn_activate.Enabled = false;
                    btn_deactivate.Enabled = false;
                    btn_catch_object.Enabled = false;
                    break;
                case "F3":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = false;
                    btn_x_down.Enabled = false;
                    btn_y_up.Enabled = false;
                    btn_y_down.Enabled = false;
                    btn_z_left.Enabled = true;
                    btn_z_right.Enabled = true;
                    btn_activate.Enabled = false;
                    btn_deactivate.Enabled = false;
                    btn_catch_object.Enabled = false;
                    break;
                case "F4":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = false;
                    btn_x_down.Enabled = false;
                    btn_y_up.Enabled = false;
                    btn_y_down.Enabled = false;
                    btn_z_left.Enabled = true;
                    btn_z_right.Enabled = true;
                    btn_activate.Enabled = false;
                    btn_deactivate.Enabled = false;
                    btn_catch_object.Enabled = false;
                    break;
                case "F5":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = true;
                    btn_x_down.Enabled = true;
                    btn_y_up.Enabled = false;
                    btn_y_down.Enabled = false;
                    btn_z_left.Enabled = false;
                    btn_z_right.Enabled = false;
                    btn_activate.Enabled = false;
                    btn_deactivate.Enabled = false;
                    btn_catch_object.Enabled = false;
                    break;
                case "G0":
                    btn_central.Enabled = true;
                    btn_x_up.Enabled = false;
                    btn_x_down.Enabled = false;
                    btn_y_up.Enabled = false;
                    btn_y_down.Enabled = false;
                    btn_z_left.Enabled = false;
                    btn_z_right.Enabled = false;
                    btn_activate.Enabled = true;
                    btn_deactivate.Enabled = true;
                    btn_catch_object.Enabled = true;
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connectionThread.Abort();
        }

        private void btn_z_left_Click(object sender, EventArgs e)
        {
            switch (cbx_joint.Text)
            {
                case "B0":
                    break;
                case "P0":
                    ClientSend.ClientControlCommand($"move_base -{ndd_step_size.Value:F6}");
                    break;
                case "F1":
                    break;
                case "F2":
                    break;
                case "F3":
                    ClientSend.ClientControlCommand($"rotate_f3 -{ndd_step_size.Value:F6}");
                    break;
                case "F4":
                    ClientSend.ClientControlCommand($"rotate_f4 -{ndd_step_size.Value:F6}");
                    break;
                case "F5":
                    break;
                case "G0":
                    break;
                default:
                    break;
            }
        }

        private void btn_update_data_Click(object sender, EventArgs e)
        {
            FillDataTable();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isRunnig)
            {
                FillDataTable();
            }
        }

        private void btn_x_up_Click(object sender, EventArgs e)
        {
            switch (cbx_joint.Text)
            {
                case "B0":
                    break;
                case "P0":
                    break;
                case "F1":
                    ClientSend.ClientControlCommand($"rotate_f1 {ndd_step_size.Value:F6}");
                    break;
                case "F2":
                    ClientSend.ClientControlCommand($"rotate_f2 {ndd_step_size.Value:F6}");
                    break;
                case "F3":
                    break;
                case "F4":
                    break;
                case "F5":
                    ClientSend.ClientControlCommand($"rotate_f5 {ndd_step_size.Value:F6}");
                    break;
                case "G0":
                    break;
                default:
                    break;
            }
        }

        private void btn_x_down_Click(object sender, EventArgs e)
        {
            switch (cbx_joint.Text)
            {
                case "B0":
                    break;
                case "P0":
                    break;
                case "F1":
                    ClientSend.ClientControlCommand($"rotate_f1 -{ndd_step_size.Value:F6}");
                    break;
                case "F2":
                    ClientSend.ClientControlCommand($"rotate_f2 -{ndd_step_size.Value:F6}");
                    break;
                case "F3":
                    break;
                case "F4":
                    break;
                case "F5":
                    ClientSend.ClientControlCommand($"rotate_f5 -{ndd_step_size.Value:F6}");
                    break;
                case "G0":
                    break;
                default:
                    break;
            }
        }

        private void btn_y_up_Click(object sender, EventArgs e)
        {
            switch (cbx_joint.Text)
            {
                case "B0":
                    ClientSend.ClientControlCommand($"rotate_base {ndd_step_size.Value:F6}");
                    break;
                case "P0":
                    break;
                case "F1":
                    break;
                case "F2":
                    break;
                case "F3":
                    break;
                case "F4":
                    break;
                case "F5":
                    break;
                case "G0":
                    break;
                default:
                    break;
            }
        }

        private void btn_y_down_Click(object sender, EventArgs e)
        {
            switch (cbx_joint.Text)
            {
                case "B0":
                    ClientSend.ClientControlCommand($"rotate_base -{ndd_step_size.Value:F6}");
                    break;
                case "P0":
                    break;
                case "F1":
                    break;
                case "F2":
                    break;
                case "F3":
                    break;
                case "F4":
                    break;
                case "F5":
                    break;
                case "G0":
                    break;
                default:
                    break;
            }
        }

        private void btn_activate_Click(object sender, EventArgs e)
        {
            if(cbx_joint.Text == "G0")
            {
                ClientSend.ClientControlCommand($"open_gripper");
            }
        }

        private void btn_deactivate_Click(object sender, EventArgs e)
        {
            if (cbx_joint.Text == "G0")
            {
                ClientSend.ClientControlCommand($"close_gripper");
            }
        }

        private void btn_catch_object_Click(object sender, EventArgs e)
        {
            if (cbx_joint.Text == "G0")
            {
                ClientSend.ClientControlCommand($"catch_object");
            }
        }
    }
}
