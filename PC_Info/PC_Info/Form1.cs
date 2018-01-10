using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Management;
//using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
//using System.Collections.Specialized;

namespace PC_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGotInfo_Click(object sender, EventArgs e)
        {
            // 提示填写自己姓名
            if(textBox_UserName.Text == "")
            {
                MessageBox.Show("请先填写姓名！");
            }
            // 只有当填写姓名后，点击“获取”才可以继续进行
            else
            {
                // 获取主机名称
                textBox_PcName.Text = System.Environment.MachineName;

                // https://zhidao.baidu.com/question/541287088.html
                // https://zhidao.baidu.com/question/1367041520433920379.html
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface adapter in interfaces)
                {
                    //if (adapter.GetPhysicalAddress().ToString() != "")
                    {
                        // 有线网卡
                        if (    adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet
                            &&  !(adapter.Description.Contains("Bluetooth"))    )
                        {
                            // MAC 地址
                            textBox_Mac_Wired.Text = adapter.GetPhysicalAddress().ToString();

                            // IP 地址
                            IPInterfaceProperties ip = adapter.GetIPProperties();
                            UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
                            foreach (UnicastIPAddressInformation ipadd in ipCollection)
                            {
                                // IPv4 地址
                                if (ipadd.Address.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    textBox_IP_Wired.Text = ipadd.Address.ToString();
                                }

                                // IPv6 地址
                                else if (ipadd.Address.AddressFamily == AddressFamily.InterNetworkV6)
                                {
                                    textBox_Wired_IPv6.Text = ipadd.Address.ToString();
                                }
                            }
                        }

                        // 无线网卡
                        if (adapter.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                        {
                            // MAC 地址
                            textBox_Mac_WireLess.Text = adapter.GetPhysicalAddress().ToString();

                            // IP 地址
                            IPInterfaceProperties ip = adapter.GetIPProperties();
                            UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
                            foreach (UnicastIPAddressInformation ipadd in ipCollection)
                            {
                                // IPv4 地址
                                if (ipadd.Address.AddressFamily == AddressFamily.InterNetwork)
                                {
                                    textBox_IP_WireLess.Text = ipadd.Address.ToString();
                                }

                                // IPv6 地址
                                else if (ipadd.Address.AddressFamily == AddressFamily.InterNetworkV6)
                                {
                                    textBox_WireLess_IPv6.Text = ipadd.Address.ToString();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonCopyInfo_Click(object sender, EventArgs e)
        {
            // 提示填写自己姓名
            if (textBox_UserName.Text == "")
            {
                MessageBox.Show("填写姓名、点击“获取”后，再点击“复制”！");
            }
            // 只有当填写姓名后，点击“获取”才可以继续进行
            else
            {
                string Msg = Convert.ToString($"姓名:\t{textBox_UserName.Text.ToString()}\r\n主机名:\t{textBox_PcName.Text.ToString()}\r\n\r\n有线网络:\r\n\tMAC:\t{textBox_Mac_Wired.Text.ToString()}\r\n\tIPv4:\t{textBox_IP_Wired.Text.ToString()}\r\n\tIPv6:\t{textBox_Wired_IPv6.Text.ToString()}\r\n\r\n无线网络:\r\n\tMAC:\t{textBox_Mac_WireLess.Text.ToString()}\r\n\tIPv4:\t{textBox_IP_WireLess.Text.ToString()}\r\n\tIPv6:\t{textBox_WireLess_IPv6.Text.ToString()}\r\n\r\n");

                if (textBox_PcName.Text != "")
                {
                    Clipboard.SetDataObject(Msg.ToString());
                }
            }

        }
    }
}
