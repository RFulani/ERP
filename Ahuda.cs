using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INV.HR1
{
    public partial class Ahuda : Form
    {
        //كلاس العهد
        Code.ClassAhuda cAhuda = new Code.ClassAhuda();
        //كلاس الاصول الثابته
        Code.ClassFixedAsset cFixedAsset = new Code.ClassFixedAsset();
        //كلاس تتبع الاوامر
        Code.ClassTrack cTrack = new Code.ClassTrack();
        public Ahuda()
        {
            InitializeComponent();
        }
        private void track_Delete()
        {
            

            DataTable dtn = new DataTable();
            dtn = cTrack.Get_Trackid();

            cTrack.mng_track_add(Convert.ToInt32(dtn.Rows[0][0].ToString()),
                                  "العهد",
                                 tb_id.Text ,
                                 tb_FixedAssest.Text + "/" + tb_Ahuda_Type.Text + "/" + tb_EmpR.Text,
                                 "حذف",
                                 Properties.Settings.Default.user_name,
                                 DateTime.Now
                );
        }
        private void track_Add()
        {
       

            DataTable dtn = new DataTable();
            dtn = cTrack.Get_Trackid();

            cTrack.mng_track_add(Convert.ToInt32(dtn.Rows[0][0].ToString()),
                                  "العهد",
                                 tb_id.Text,
                                 tb_FixedAssest.Text + "/" + tb_Ahuda_Type.Text + "/" + tb_EmpR.Text,
                                 "إضافه",
                                 Properties.Settings.Default.user_name,
                                 DateTime.Now
                );
        }
        private void track_Update()
        {
 
            DataTable dtn = new DataTable();
            dtn = cTrack.Get_Trackid();

            cTrack.mng_track_add(Convert.ToInt32(dtn.Rows[0][0].ToString()),
                                  "العهد",
                                 tb_id.Text,
                                 tb_FixedAssest.Text + "/" + tb_Ahuda_Type.Text + "/" + tb_EmpR.Text,
                                 "تعديل",
                                 Properties.Settings.Default.user_name,
                                 DateTime.Now
                );
        }
        //(Async)حفظ الإضافة
        private void saveAdd()
        {
            try
            {
                //التاريخ
                DateTime tb_Ahuda_Date = DateTime.ParseExact(mtb_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //--------
                cAhuda.mng_Ahuda_add(Convert.ToInt32(tb_id.Text)
                                     , tb_Ahuda_Type.Text
                                     , Convert.ToInt32(lbl_EmpR.Text)
                                     , tb_EmpR.Text
                                     , Convert.ToInt32(lbl_FixedAssest_id.Text)
                                     , tb_FixedAssest.Text
                                     , tb_EmpS.Text
                                     , tb_Ahuda_Date
                                     , tb_notes.Text
                                     , tb_Ahuda_stat.Text
                                    //Created By & Created Date
                                    , Properties.Settings.Default.user_name
                                    , DateTime.Now
                                      );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //(Async)حفظ التعديل
        private void SaveUpdate()
        {
            try
            {
                //التاريخ
                DateTime tb_Ahuda_Date = DateTime.ParseExact(mtb_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //--------
                cAhuda.mng_Ahuda_Update(Convert.ToInt32(tb_id.Text)
                                     , tb_Ahuda_Type.Text
                                     , Convert.ToInt32(lbl_EmpR.Text)
                                     , tb_EmpR.Text
                                     , Convert.ToInt32(lbl_FixedAssest_id.Text)
                                     , tb_FixedAssest.Text
                                     , tb_EmpS.Text
                                     , tb_Ahuda_Date
                                     , tb_notes.Text
                                     , tb_Ahuda_stat.Text
                                    //Created By & Created Date
                                    , Properties.Settings.Default.user_name
                                    , DateTime.Now
                                      );

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //(Async)حذف
        private void delete()
        {
            try
            {

                cAhuda.mng_Ahuda_Del(Convert.ToInt32(tb_id.Text));
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //تفعيل الحقول 
        private void enable()
        {
            tb_id.ReadOnly = false;
            mtb_date.ReadOnly = false;
            tb_Ahuda_Type.ReadOnly = false;
            tb_Ahuda_stat.ReadOnly = false;
            tb_FixedAssest.ReadOnly = false;
            tb_EmpR.ReadOnly = false;
            tb_EmpS.ReadOnly = false;
            tb_notes.ReadOnly = false;

            btn_pickAssest.Enabled = true;
            btn_pickR.Enabled = true;
            btn_pickS.Enabled = true;
        }
        //تعطيل الحقول 
        private void disable()
        {
            tb_id.ReadOnly = true;
            mtb_date.ReadOnly = true;
            tb_Ahuda_Type.ReadOnly = true;
            tb_Ahuda_stat.ReadOnly = true;
            tb_FixedAssest.ReadOnly = true;
            tb_EmpR.ReadOnly = true;
            tb_EmpS.ReadOnly = true;
            tb_notes.ReadOnly = true;

            btn_pickAssest.Enabled = false;
            btn_pickR.Enabled = false;
            btn_pickS.Enabled = false;
        }
        //تفريغ الشاشة
        private void ResetTheScreen()
        {
            tb_id.Text = "0";
            mtb_date.Clear();
            tb_Ahuda_Type.Clear();
            tb_Ahuda_stat.Clear();
            tb_FixedAssest.Clear();
            tb_EmpR.Clear();
            tb_EmpS.Clear();
            tb_notes.Clear();


            //إضافه
            btn_Add.Enabled = true;
            //تعديل
            btn_Edit.Enabled = false;
            //البحث
            btn_Search.Enabled = true;
            //حفظ الإضافه
            btn_SaveAdd.Visible = false;
            //حفظ التعديل
            btn_SaveUpdate.Visible = false;
            //حذف
            btn_Delete.Enabled = false;
            //مسح الشاشه
            btn_Clear.Enabled = true;
            //الطباعه
            btn_Print.Enabled = false;
            //الخروج
            btn_Exit.Enabled = true;

            disable();
        }
        //إضافة الأرقام التسلسلية
        private void setRowNumber(DataGridView dgv_Ahuda)
        {
            foreach (DataGridViewRow row in dgv_Ahuda.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
        //*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*

        private void Ahuda_Load(object sender, EventArgs e)
        {

        }
        //*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*
        //إختيار الأصل
        private void btn_pickAssest_Click(object sender, EventArgs e)
        {
            try
            {
                
                    Accontent.SearchFixedAsset sFixedAsset = new Accontent.SearchFixedAsset();
                    sFixedAsset.lbl_FixedAsset.Text = "0";
                    sFixedAsset.ShowDialog();

                    //جلب بيانات   الى الادوات

                    if (sFixedAsset.lbl_FixedAsset.Text == "1")
                    {

                        tb_FixedAssest.Text = sFixedAsset.dgv.CurrentRow.Cells[2].Value.ToString();
                        lbl_FixedAssest_id.Text = sFixedAsset.dgv.CurrentRow.Cells[0].Value.ToString();
                    DataTable dtFixedAsse = new DataTable();
                    int FixedAsse_id = Convert.ToInt32(sFixedAsset.dgv.CurrentRow.Cells[0].Value.ToString());
                    dtFixedAsse = cFixedAsset.ShowFixedAsset(FixedAsse_id);
                    if (dtFixedAsse.Rows[0]["FixedAsset_image"].ToString() != string.Empty && dtFixedAsse.Rows[0]["FixedAsset_image"].ToString() != null)
                    {
                        byte[] image1 = (byte[])dtFixedAsse.Rows[0]["FixedAsset_image"];
                        MemoryStream ms = new MemoryStream(image1);
                        pictureBox1.Image = Image.FromStream(ms);
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //إختيار المستلم
        private void btn_pickR_Click(object sender, EventArgs e)
        {
            try
            {

                HR1.SerachEmp semp = new HR1.SerachEmp();

                semp.label1.Text = "0";
                semp.ShowDialog();

                //جلب بيانات   الى الادوات

                if (semp.label1.Text == "1")
                {

                    tb_EmpR.Text = semp.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    lbl_EmpR.Text = semp.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //إختيار المسلم
        private void btn_pickS_Click(object sender, EventArgs e)
        {
            try
            {

                HR1.SerachEmp semp = new HR1.SerachEmp();

                semp.label1.Text = "0";
                semp.ShowDialog();

                //جلب بيانات   الى الادوات

                if (semp.label1.Text == "1")
                {

                    tb_EmpS.Text = semp.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    lbl_EmpS.Text = semp.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //*--*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-*
        //إضافة
        private void btn_Add_Click(object sender, EventArgs e)
        {
            enable();
            //إضافة أرقام
            DataTable dt = new DataTable();
            dt = cAhuda.Get_AhudaId();
            tb_id.Text = dt.Rows[0][0].ToString();

            //إضافة تاريخ اليوم
            mtb_date.Text = $"{DateTime.Now:dd/MM/yyyy}";


            // تفعيل الأزرار
            //إضافه
            btn_Add.Enabled = false;
            //تعديل
            btn_Edit.Enabled = false;
            //البحث
            btn_Search.Enabled = false;
            //حفظ الإضافه
            btn_SaveAdd.Visible = true;
            //حفظ التعديل
            btn_SaveUpdate.Visible = false;
            //حذف
            btn_Delete.Enabled = false;
            //مسح الشاشه
            btn_Clear.Enabled = true;
            //الطباعه
            btn_Print.Enabled = false;
            //الخروج
            btn_Exit.Enabled = true;

        }
        //حفظ الإضافة
        private async void btn_SaveAdd_Click(object sender, EventArgs e)
        {
            try
            {

                //       //التاريخ
                //       DateTime tb_Ahuda_Date = DateTime.ParseExact(mtb_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                //       //--------
                //cAhuda.mng_Ahuda_add(Convert.ToInt32(tb_id.Text)
                //                     , tb_Ahuda_Type.Text
                //                     , Convert.ToInt32(lbl_EmpR.Text)
                //                     , tb_EmpR.Text
                //                     , Convert.ToInt32(lbl_FixedAssest_id.Text)
                //                     , tb_FixedAssest.Text
                //                     , tb_EmpS.Text
                //                     , tb_Ahuda_Date 
                //                     , tb_notes.Text
                //                     , tb_Ahuda_stat.Text
                //                    //Created By & Created Date
                //                    , Properties.Settings.Default.user_name
                //                    , DateTime.Now
                //                      );

                Prossing prs = new Prossing();
                prs.Show();
                await Task.Run(new Action(saveAdd));
                prs.Close();
                //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
                await Task.Run(new Action(track_Add));
                //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

                MessageBox.Show("تم حفظ بيانات العهده بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Ahuda.DataSource = cAhuda.Show_AllAhuda();
                //إضافه
                btn_Add.Enabled = true;
                //تعديل
                btn_Edit.Enabled = false;
                //البحث
                btn_Search.Enabled = true;
                //حفظ الإضافه
                btn_SaveAdd.Visible = false;
                //حفظ التعديل
                btn_SaveUpdate.Visible = false;
                //حذف
                btn_Delete.Enabled = false;
                //مسح الشاشه
                btn_Clear.Enabled = true;
                //الطباعه
                btn_Print.Enabled = true;
                //الخروج
                btn_Exit.Enabled = true;

                //هل تريد مسح الشاشة....؟
                if (MessageBox.Show("هل تريد مسح الشاشة ؟", "مسح الشاشة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetTheScreen();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //التعديل
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            enable();
            // تفعيل الأزرار
            //إضافه
            btn_Add.Enabled = false;
            //تعديل
            btn_Edit.Enabled = false;
            //البحث
            btn_Search.Enabled = false;
            //حفظ الإضافه
            btn_SaveAdd.Visible = false;
            //حفظ التعديل
            btn_SaveUpdate.Visible = true;
            //حذف
            btn_Delete.Enabled = false;
            //مسح الشاشه
            btn_Clear.Enabled = true;
            //الطباعه
            btn_Print.Enabled = false;
            //الخروج
            btn_Exit.Enabled = true;

        }
        //حفظ التعديل
        private async void btn_SaveUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ////التاريخ
                //DateTime tb_Ahuda_Date = DateTime.ParseExact(mtb_date.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                ////--------
                //cAhuda.mng_Ahuda_Update(Convert.ToInt32(tb_id.Text)
                //                     , tb_Ahuda_Type.Text
                //                     , Convert.ToInt32(lbl_EmpR.Text)
                //                     , tb_EmpR.Text
                //                     , Convert.ToInt32(lbl_FixedAssest_id.Text)
                //                     , tb_FixedAssest.Text
                //                     , tb_EmpS.Text
                //                     , tb_Ahuda_Date
                //                     , tb_notes.Text
                //                     , tb_Ahuda_stat.Text
                //                    //Created By & Created Date
                //                    , Properties.Settings.Default.user_name
                //                    , DateTime.Now
                //                      );
                Prossing prs = new Prossing();
                prs.Show();
                await Task.Run(new Action(SaveUpdate));
                prs.Close();
                //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
                await Task.Run(new Action(track_Update));
                //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

                MessageBox.Show("تم  تعديل العهده بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv_Ahuda.DataSource = cAhuda.Show_AllAhuda();
                //إضافه
                btn_Add.Enabled = true;
                //تعديل
                btn_Edit.Enabled = false;
                //البحث
                btn_Search.Enabled = true;
                //حفظ الإضافه
                btn_SaveAdd.Visible = false;
                //حفظ التعديل
                btn_SaveUpdate.Visible = false;
                //حذف
                btn_Delete.Enabled = false;
                //مسح الشاشه
                btn_Clear.Enabled = true;
                //الطباعه
                btn_Print.Enabled = true;
                //الخروج
                btn_Exit.Enabled = true;

                //هل تريد مسح الشاشة....؟
                if (MessageBox.Show("هل تريد مسح الشاشة ؟", "مسح الشاشة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetTheScreen();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //البحث
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                ResetTheScreen();
                HR1.SearchAhuda sAhuda = new HR1.SearchAhuda();
                DataTable dtAhuda = new DataTable();
                sAhuda.lbl_Ahuda.Text = "0";
                sAhuda.ShowDialog();
                //جلب بيانات  الى الادوات
                if (sAhuda.lbl_Ahuda.Text == "1")
                {
                    int Ahuda_id = Convert.ToInt32(sAhuda.dgv.CurrentRow.Cells[0].Value.ToString());
                    dtAhuda = cAhuda.ShowAhuda(Ahuda_id);

                    tb_id.Text = dtAhuda.Rows[0]["assets_id"].ToString();
                    tb_Ahuda_Type.Text = dtAhuda.Rows[0]["assets_Type"].ToString();
                    lbl_EmpR.Text = dtAhuda.Rows[0]["emp_id"].ToString();
                    tb_EmpR.Text = dtAhuda.Rows[0]["emp_name"].ToString();
                    lbl_FixedAssest_id.Text = dtAhuda.Rows[0]["FixedAsset_id"].ToString();
                    //*************************************************************************
                    DataTable dtFixedAsse = new DataTable();
                    int FixedAsse_id = Convert.ToInt32(dtAhuda.Rows[0]["FixedAsset_id"]);
                    dtFixedAsse = cFixedAsset.ShowFixedAsset(FixedAsse_id);
                    if(dtFixedAsse.Rows.Count != 0)
                    {
                        if (dtFixedAsse.Rows[0]["FixedAsset_image"].ToString() != string.Empty && dtFixedAsse.Rows[0]["FixedAsset_image"].ToString() != null)
                        {
                            byte[] image1 = (byte[])dtFixedAsse.Rows[0]["FixedAsset_image"];
                            MemoryStream ms = new MemoryStream(image1);
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                    }
                    //*************************************************************************

                    tb_FixedAssest.Text = dtAhuda.Rows[0]["FixedAsset_Name_Ar"].ToString();
                    tb_EmpS.Text = dtAhuda.Rows[0]["assets_Supervisor"].ToString();
                    mtb_date.Text = Convert.ToDateTime(dtAhuda.Rows[0]["assets_date"]).ToString("dd/MM/yyyy");
                    tb_notes.Text = dtAhuda.Rows[0]["assets_note"].ToString();
                    tb_Ahuda_stat.Text = dtAhuda.Rows[0]["Ahuda_stat"].ToString();

                    //إضافه
                    btn_Add.Enabled = true;
                    //تعديل
                    btn_Edit.Enabled = true;
                    //البحث
                    btn_Search.Enabled = true;
                    //حفظ الإضافه
                    btn_SaveAdd.Visible = false;
                    //حفظ التعديل
                    btn_SaveUpdate.Visible = false;
                    //حذف
                    btn_Delete.Enabled = true;
                    //الطباعه
                    btn_Print.Enabled = true;
                    //مسح الشاشه
                    btn_Clear.Enabled = true;
                    //
                    btn_Exit.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //الحذف
        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("الرجاء التاكيد على الرغبة بحذف العهد", "حذف العهد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //cAhuda.mng_Ahuda_Del(Convert.ToInt32(tb_id.Text));
                    Prossing prs = new Prossing();
                    prs.Show();
                    await Task.Run(new Action(delete));
                    prs.Close();

                    MessageBox.Show("تم حذف العهد بنجاح", "حذف العهد");
                    //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
                    await Task.Run(new Action(track_Delete));
                    //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*

                    ResetTheScreen();
                    dgv_Ahuda.DataSource = cAhuda.Show_AllAhuda();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //عرض جميع العهد
        private void btShow_Click(object sender, EventArgs e)
        {
            try
            {
                //جلب بيانات الاله الى الجريد
                dgv_Ahuda.DataSource = cAhuda.Show_AllAhuda();


                //لإضافة الأرقام التسلسلي لل (data grid view)
                setRowNumber(dgv_Ahuda);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //مسح الشاشة
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ResetTheScreen();
        }
        //الطباعة
        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {

                //تعريف المفات
                HRPrintRP.CRAhuda CRAhuda = new HRPrintRP.CRAhuda();
                //ثابته
                Printfile.fprintinv fprint = new Printfile.fprintinv();
                //اتصال قاعدة البيانات
                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables;
                CRAhuda.Load("HR1/HRPrintRP/CRAhuda.rpt");

                crConnectionInfo.ServerName = Properties.Settings.Default.server;
                crConnectionInfo.DatabaseName = Properties.Settings.Default.database;
                crConnectionInfo.UserID = Properties.Settings.Default.user_data;
                crConnectionInfo.Password = Properties.Settings.Default.pass_data;
                CrTables = CRAhuda.Database.Tables;

                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
                }
                //المتغيرات
                CRAhuda.SetParameterValue("@assets_id", Convert.ToInt32(tb_id.Text));
                //الطباعة
                fprint.crystalReportViewer1.ReportSource = CRAhuda;
                fprint.crystalReportViewer1.Refresh();
                fprint.Show();
                //-------------------------------------

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //الخروج
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج ؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TabPage a;
                a = (TabPage)(this.Parent);
                TabControl b;
                b = (System.Windows.Forms.TabControl)a.Parent;
                b.TabPages.Remove(a);
            }

        }
        //النقر مرتين على الداتا جريد - إسترجاع البيانات
        private void dgv_Ahuda_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                disable();
                foreach (DataGridViewCell AhudaCell in dgv_Ahuda.SelectedCells)
                {
                    DataTable dtAhuda = new DataTable();
                    dtAhuda = cAhuda.ShowAhuda(Convert.ToInt32(dgv_Ahuda.CurrentRow.Cells[0].Value.ToString()));
                    if (AhudaCell.Selected)
                    {


                        tb_id.Text = dtAhuda.Rows[0]["assets_id"].ToString();
                        tb_Ahuda_Type.Text = dtAhuda.Rows[0]["assets_Type"].ToString();
                        lbl_EmpR.Text = dtAhuda.Rows[0]["emp_id"].ToString();
                        tb_EmpR.Text = dtAhuda.Rows[0]["emp_name"].ToString();
                        lbl_FixedAssest_id.Text = dtAhuda.Rows[0]["FixedAsset_id"].ToString();

                        //*********************************************************************************************************************************************************************************************************************
                        DataTable dtFixedAsse = new DataTable();
                        int FixedAsse_id = Convert.ToInt32(dtAhuda.Rows[0]["FixedAsset_id"]);
                        dtFixedAsse = cFixedAsset.ShowFixedAsset(FixedAsse_id);
                        if (dtFixedAsse.Rows.Count != 0)
                        {
                            if (dtFixedAsse.Rows[0]["FixedAsset_image"].ToString() != string.Empty && dtFixedAsse.Rows[0]["FixedAsset_image"].ToString() != null)
                            {
                                byte[] image1 = (byte[])dtFixedAsse.Rows[0]["FixedAsset_image"];
                                MemoryStream ms = new MemoryStream(image1);
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        //*********************************************************************************************************************************************************************************************************************
                        
                        tb_FixedAssest.Text = dtAhuda.Rows[0]["FixedAsset_Name_Ar"].ToString();
                        tb_EmpS.Text = dtAhuda.Rows[0]["assets_Supervisor"].ToString();
                        mtb_date.Text = Convert.ToDateTime(dtAhuda.Rows[0]["assets_date"]).ToString("dd/MM/yyyy");
                        tb_notes.Text = dtAhuda.Rows[0]["assets_note"].ToString();
                        tb_Ahuda_stat.Text = dtAhuda.Rows[0]["Ahuda_stat"].ToString();

                        //إضافه
                        btn_Add.Enabled = true;
                        //تعديل
                        btn_Edit.Enabled = true;
                        //البحث
                        btn_Search.Enabled = true;
                        //حفظ الإضافه
                        btn_SaveAdd.Visible = false;
                        //حفظ التعديل
                        btn_SaveUpdate.Visible = false;
                        //حذف
                        btn_Delete.Enabled = true;
                        //الطباعه
                        btn_Print.Enabled = true;
                        //مسح الشاشه
                        btn_Clear.Enabled = true;
 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
