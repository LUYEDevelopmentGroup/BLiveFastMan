using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using BiliApi;
using BililiveRecorder.Core;
using System.Media;
using System.Text.RegularExpressions;

namespace FastBan
{
    public partial class ManagementWindow : Form
    {
        StreamMonitor sm;
        Queue<DanmakuModel> procqueue;
        Dictionary<string, UserInfo> uinfo;
        ThirdPartAPIs api;
        BiliLiveRoom liveroom;

        public class UserInfo
        {
            public Image head;
            public bool IsAdmin, IsPaidUser;
            public int uid;
        }

        public ManagementWindow()
        {
            InitializeComponent();
            uinfo = new Dictionary<string, UserInfo>();
            api = new ThirdPartAPIs(Program.biliauth.Cookies);
            procqueue = new Queue<DanmakuModel>();
            new Thread(new ThreadStart(() =>
            {
                while (rrun)
                {
                    while (rrun && procqueue.Count == 0) Thread.Sleep(1);
                    if (!rrun) break;
                    ProcessDanmaku(procqueue.Dequeue());
                }
            })).Start();
        }

        private void run_CheckedChanged(object sender, EventArgs e)
        {
            if (run.Checked)
            {
                sm = new StreamMonitor((int)roomnumber.Value, () => { return new System.Net.Sockets.TcpClient(); });
                liveroom = new BiliLiveRoom((int)roomnumber.Value, api);
                sm.ReceivedDanmaku += Sm_ReceivedDanmaku;
                sm.Start();
            }
            else
            {
                sm.Stop();
            }
        }

        private void Sm_ReceivedDanmaku(object sender, ReceivedDanmakuArgs e)
        {
            procqueue.Enqueue(e.Danmaku);
        }

        private void ProcessDanmaku(DanmakuModel dmk)
        {
            if (dmk.MsgType == MsgTypeEnum.Comment)
            {
                PutDanmakuToListbox(dmk, danmaku_all);
                bool hit = false;
                foreach (var reg in filter.Lines)
                {
                    if (reg.Length > 1)
                    {
                        if (Regex.IsMatch(dmk.CommentText, reg))
                        {
                            hit = true;
                            break;
                        }
                    }
                }
                if (hit)
                {
                    PutDanmakuToListbox(dmk, danmaku_hit);
                    SystemSounds.Beep.Play();
                }
            }
        }

        private Image getImage(string uu)
        {
            Uri url = new Uri(uu);
            WebClient request = new WebClient();
            var i = Image.FromStream(request.OpenRead(url));
            request.Dispose();
            return i;
        }

        private void PutDanmakuToListbox(DanmakuModel dmk, ListBox lb)
        {
            if (!uinfo.ContainsKey(dmk.UserName))
            {
                uinfo.Add(dmk.UserName, new UserInfo()
                {
                    IsAdmin = dmk.IsAdmin,
                    IsPaidUser = dmk.IsVIP,
                    uid = dmk.UserID
                });
                try
                {
                    uinfo[dmk.UserName].head = getImage(new BiliUser(dmk.UserID, api).face);
                }
                catch
                {
                    uinfo[dmk.UserName].head = null;
                }
            }
            if (uinfo[dmk.UserName].head == null)
            {
                try
                {
                    uinfo[dmk.UserName].head = getImage(new BiliUser(dmk.UserID, api).face);
                }
                catch
                {
                    uinfo[dmk.UserName].head = null;
                }
            }

            lb.Items.Add(dmk.UserName + ":" + dmk.CommentText);
            if (lb.Items.Count > 50)
            {
                lb.Items.RemoveAt(0);
            }
        }

        private void danmaku_all_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                ListBox lb = (ListBox)sender;
                Brush myBrush = Brushes.Black;
                Color RowBackColorSel = Color.FromArgb(150, 200, 250);//选择项目颜色
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    myBrush = new SolidBrush(RowBackColorSel);
                }
                else
                {
                    myBrush = new SolidBrush(Color.White);
                }
                e.Graphics.FillRectangle(myBrush, e.Bounds);
                e.DrawFocusRectangle();//焦点框

                //绘制图标
                Image image = uinfo[lb.Items[e.Index].ToString().Split(':')[0]].head;
                Graphics graphics = e.Graphics;
                Rectangle bound = e.Bounds;
                Rectangle imgRec = new Rectangle(
                    bound.X,
                    bound.Y,
                    bound.Height,
                    bound.Height);
                Size nameplate = TextRenderer.MeasureText(e.Graphics, lb.Items[e.Index].ToString().Split(':')[0], e.Font, new Size(0, 0), TextFormatFlags.NoPadding);
                Rectangle nameRec = new Rectangle(
                    imgRec.Right,
                    bound.Y,
                    nameplate.Width,
                    bound.Height);
                Rectangle textRec = new Rectangle(
                    nameRec.Right,
                    bound.Y,
                    bound.Width - nameRec.Right,
                    bound.Height);
                if (image != null)
                {
                    e.Graphics.DrawImage(
                        image,
                        imgRec,
                        0,
                        0,
                        image.Width,
                        image.Height,
                        GraphicsUnit.Pixel);
                    //绘制字体
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Near;
                    Color namecolor = Color.Black;
                    if (uinfo[lb.Items[e.Index].ToString().Split(':')[0]].IsPaidUser) namecolor = Color.Orange;
                    if (uinfo[lb.Items[e.Index].ToString().Split(':')[0]].IsAdmin) namecolor = Color.DarkGreen;
                    e.Graphics.DrawString(lb.Items[e.Index].ToString().Split(':')[0], e.Font, new SolidBrush(namecolor), nameRec, stringFormat);
                    e.Graphics.DrawString(":" + lb.Items[e.Index].ToString().Split(':')[1], e.Font, new SolidBrush(Color.DarkGray), textRec, stringFormat);
                }
            }
            catch { }
        }

        ListBox rrlb;

        private void 清空ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox lb = rrlb;
            lb.Items.Clear();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ListBox lb = (ListBox)(sender as ContextMenuStrip).SourceControl;
            rrlb = lb;
            bool a = lb.SelectedItems.Count == 1;
            Ban1Hour_BanToolStripMenuItem.Visible = a;
        }

        bool rrun = true;
        private void ManagementWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            rrun = false;
        }

        private void Ban1Hour_BanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox lb = rrlb;
            string name = lb.SelectedItem.ToString().Split(':')[0];
            int id = uinfo[name].uid;
            liveroom.manage.banUID(id);
        }
    }
}
